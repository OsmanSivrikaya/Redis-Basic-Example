# Caching & Redis Examples

Bu projede, dört farklı örnek bulunmaktadır: Distributed Caching API Controller, InMemoryCaching API Controller, Redis Pub-Sub Publisher Console ve Redis Pub-Sub Subscriber Console. Bu örnekler, caching ve mesajlaşma konularında temel kavramları ve kullanım senaryolarını göstermektedir.

## 📁 Proje Yapısı
- **Distributed Caching API Controller** (`/DistributedCaching`)
- **InMemoryCaching API Controller** (`/InMemoryCaching`)
- **Redis Pub-Sub Publisher Console** (`/RedisPublisher`)
- **Redis Pub-Sub Subscriber Console** (`/RedisSubscriber`)

---

## 🌐 Distributed Caching API Controller

### 📂 Klasör: `/DistributedCaching`
### 📝 Açıklama:
Distributed Caching API Controller, verilerin birden fazla sunucuda cache'lenmesini sağlar. Bu yöntem, ölçeklenebilirlik ve güvenlik açısından daha avantajlıdır. Bu örnekte Redis kullanılarak distributed cache yapılandırılmıştır.

### 💡 Nedir?
Distributed Caching, verileri birden fazla sunucuda saklayarak yüksek erişilebilirlik ve ölçeklenebilirlik sağlar. Veriler, farklı sunuculara dağıtılarak depolanır ve bu sayede tek bir sunucunun çökmesi durumunda bile verilere erişim devam eder.

### 📚 Kullanım Alanları:
- Büyük ölçekli web uygulamaları
- Dağıtık sistemler
- Yüksek trafikli uygulamalar

---

## 🌐 InMemoryCaching API Controller

### 📂 Klasör: `/InMemoryCaching`
### 📝 Açıklama:
InMemoryCaching API Controller, verilerin uygulamanın RAM'inde saklanmasını sağlar. Bu yöntem, tek bir sunucu üzerinde çalışır ve hızlı erişim sağlar.

### 💡 Nedir?
InMemory Caching, verilerin uygulamanın çalıştığı sunucunun belleğinde saklanmasıdır. Bu yöntem, verilerin hızlı bir şekilde erişilmesini sağlar, ancak ölçeklenebilirlik ve güvenlik açısından sınırlıdır.

### 📚 Kullanım Alanları:
- Küçük ölçekli uygulamalar
- Sık erişilen ancak nadiren güncellenen veriler

---

## 💻 Redis Pub-Sub Publisher Console

### 📂 Klasör: `/RedisPublisher`
### 📝 Açıklama:
Redis Pub-Sub Publisher Console, Redis üzerinden mesajlar yayınlamak için kullanılır. Publisher, belirli bir kanala mesaj gönderir.

### 💡 Nedir?
Redis Pub/Sub (Yayınla/Abone Ol) modeli, mesajların kanallar aracılığıyla yayınlanmasını ve abone olan istemciler tarafından alınmasını sağlar. Publisher, belirli bir kanala mesaj gönderir ve bu mesajlar abone olan tüm istemcilere iletilir.

### 📚 Kullanım Alanları:
- Gerçek zamanlı bildirim sistemleri
- Mesajlaşma uygulamaları
- Veri yayma sistemleri

---

## 💻 Redis Pub-Sub Subscriber Console

### 📂 Klasör: `/RedisSubscriber`
### 📝 Açıklama:
Redis Pub-Sub Subscriber Console, Redis üzerinden yayınlanan mesajları dinlemek için kullanılır. Subscriber, belirli bir kanaldan mesaj alır.

### 💡 Nedir?
Redis Pub/Sub (Yayınla/Abone Ol) modeli, mesajların kanallar aracılığıyla yayınlanmasını ve abone olan istemciler tarafından alınmasını sağlar. Subscriber, belirli bir kanala abone olarak bu kanaldan gelen mesajları dinler ve işler.

### 📚 Kullanım Alanları:
- Gerçek zamanlı veri izleme
- Bildirim sistemleri
- Anlık mesajlaşma

---

Not: İçerikler Gencay Yıldız Redis eğitiminden esinlenilmiştir.
