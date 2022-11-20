# UserTokenScope

## Права доступа

Права доступа определяют возможность использования токена для работы с тем или иным разделом данных. Так, например, для отправки личного сообщения от имени пользователя токен должен быть получен с правами messages.

Список названий прав доступа, которые необходимы приложению,  или сумма их битовых масок передается в параметре scope в процессе получения ключа доступа.

Атрибут | Битовые представления | Описание
--- | --- | ---
Notify | (+1)   (1 << 0)	 | Пользователь разрешил отправлять ему уведомления.
Friends | (+2)   (1 << 1) | Доступ к друзьям.
Photos | (+4)   (1 << 2) | Доступ к фотографиям.
Video | (+8)   (1 << 3) | Доступ к видеозаписям.
Files | (+16)   (1 << 4) | Доступ к файлам.
Documents | (+32)   (1 << 5) | Доступ к документам.