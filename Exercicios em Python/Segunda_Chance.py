#Você se voluntariou para implementar esse software, que precisa receber um valor inicial
#indicando a quantidade de alunos da turma, seguido pelas notas originais de cada aluno
#e pelas notas obtidas na nova atividade. O programa deverá exibir a quantidade de alunos
#que tiveram suas notas alteradas, assim como as notas originais e finais de cada aluno,
#destacando aqueles que aumentaram as notas.

N = int(input())

def obter_notas():
  notas = []

  for _ in range(N):
    notas.append(float(input()))

  return notas

def obter_notas_finais(notas_originais, novas_notas):
  quantidade_notas_alteradas = 0

  for i in range(len(notas_originais)):
    if (novas_notas[i] == 10 and notas_originais[i] < 10):
      novas_notas[i] = min(notas_originais[i] + 2, 10)
      quantidade_notas_alteradas += 1
    else:
      novas_notas[i] = notas_originais[i]

  return quantidade_notas_alteradas

def exibir_notas_alteradas(notas_originais, notas_finais, quantidade_notas_alteradas):
  print(f'NOTAS ALTERADAS: {quantidade_notas_alteradas}')
  for i in range(N):
    nota_alterada = ('*' if notas_originais[i] != notas_finais[i] else '-')
    print(f'{nota_alterada}({i+1:03}) original: {notas_originais[i]:05.2f} | final: {notas_finais[i]:05.2f}')

if (1 <= N <= 999):
  notas_originais = obter_notas()
  novas_notas = obter_notas()
  quantidade_notas_alteradas = obter_notas_finais(notas_originais, novas_notas)
  exibir_notas_alteradas(notas_originais, novas_notas, quantidade_notas_alteradas)
