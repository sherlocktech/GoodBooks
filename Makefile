PROJECT_NAME ?= GoodBooks

.PHONY: migrations db

migrations:
	cd ./GoodBooks.Data && dotnet ef --startup-project ../GoodBooks.Web/ migrations add $(mname) && cd ..

db:
	cd ./GoodBooks.Data && dotnet ef --startup-project ../GoodBooks.Web/ database update && cd ..