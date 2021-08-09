import express from 'express';

const app = express();
app.use(express.json());
const port = 3000;

app.get('/', (req, res) => {
  res.send('Hello World!');
});

app.post('/sum', (req, res) => {
  console.log(req);

  const { num1, num2 } = req.body;

  res.send(`o resultado ${num1 + num2}`);
});

app.listen(port, () => {
  console.log(`Server is listening on port ${port}`);
});
