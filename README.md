# Sistema web de previsão de tempo com machine learning e PWA

## Objetivo

O principal objetivo é criar um sistema de previsão de tempo, utilizando tecnologias fornecer informações meteorológicas precisas e relevantes. Integrando React JS com PWA (Progressive Web App), C#, e Python, oferecendo uma experiência de usuário excepcional em plataformas web, desktop e mobile.

O foco principal do sistema é apresentar aos usuários previsões meteorológicas baseadas em dados históricos confiáveis. Combinando esses dados, o sistema calculará previsões para elementos críticos como temperatura, umidade, velocidade do ar e a probabilidade de precipitação. A abordagem inclusiva de PWA garante que as previsões estejam disponíveis em qualquer lugar, a qualquer momento, proporcionando uma experiência de uso perfeita, independentemente do dispositivo escolhido.

## Escopo

1. Coleta de Dados:
    - Coleta de dados meteorológicos históricos de fontes confiáveis.

2. Pré-processamento e Análise:
    - Desenvolvimento de algoritmos para pré-processar os dados coletados, incluindo limpeza e normalização.
    - Implementação de técnicas de análise estatística para identificar padrões e tendências nos dados.

3. Modelagem e Previsão:
    - Desenvolvimento de modelos de previsão baseados em aprendizado de máquina.
    - Treinamento dos modelos utilizando dados históricos para prever elementos meteorológicos como temperatura, umidade, velocidade do ar e probabilidade de precipitação.

4. Design de Interface:
    - Criação de um layout intuitivo e atraente para a interface do usuário, focado na apresentação clara das informações meteorológicas.

5. Desenvolvimento:
    - Desenvolvimento das telas criadas.
    - Desenvolvimento das APIs para o back-end.

6. Qualidade:
    - Implementação de testes unitários no back-end.
    - Implementação de testes E2E no front-end.
    - Realização de testes manuais em todas as plataformas para garantir o funcionamento correto do sistema.
    - Validação das previsões geradas comparando-as com dados reais e outras fontes confiáveis.
    - Analise de qualidade de código com SonarQube.

7. CI/CD:
    - Implementação de Continuous Integration e Continous Delivery.
  
8. Obeservabilidade: 
    - Aplicação de softwares para monitoramento.

## Contexto

O Sistema de Previsão de Tempo Multiplataforma é uma solução de software inovadora desenvolvida para fornecer informações meteorológicas precisas e acessíveis a usuários em várias plataformas.

## Restrições
- Custo para manter o sistema em publicado.

## Trade-offs

- Portabilidade
A escolha de desenvolver o sistema como um Progressive Web App (PWA) pode resultar em maior portabilidade em comparação com aplicativos nativos.

- Funcionalidade
Buscar oferecer uma ampla gama de recursos de previsão meteorológica pode resultar em um sistema complexo. Isso pode afetar a experiência do usuário, tornando a interface mais densa e potencialmente confusa. Aplicar uma interface mais simples irá melhorar a experiência do usuário e também facilitará o uso.

- Usabilidade
Priorizar a usabilidade pode levar a uma interface de usuário mais limpa e intuitiva. No entanto, a simplificação excessiva pode levar à redução da profundidade das informações apresentadas. Como por exemplo: Não apresentar gráficos.

- Confiabilidade
Para garantir a confiabilidade das previsões, é necessário incorporar algoritmos sofisticados e dados de qualidade. Isso pode aumentar o tempo necessário para processar as previsões, impactando potencialmente a velocidade de resposta do sistema.

- Eficiência
Ao implementar algoritmos complexos para previsão meteorológica, pode haver um aumento no uso de recursos computacionais. Isso pode afetar o desempenho do sistema, causando lentidão.

- Manutenibilidade
Por ser um sistema simples, a manutenabilidade dele será mínima, investindo em testes tornará a manutenção no futuro mais facil, porém dificultará o desenvolvimento inicial.
## C4 - Contexto

<p align="center">
  <img src="https://github.com/GustavoBoscoGit/weather-prediction-portfolio-backend/assets/88805708/fac4eabe-b731-481f-8afe-750a3bbfce27">
</p>


## C4 - Containers

<p align="center">
  <img src="https://github.com/GustavoBoscoGit/weather-prediction-portfolio-backend/assets/88805708/d7999ce6-57eb-4a1a-8036-72539a0376e2">
</p>



