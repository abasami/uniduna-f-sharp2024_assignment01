//1
printf "2022-1: check whether 12 is even --> "
// 数値が偶数かどうかを判断する関数
let isEven (n: int) =
    n % 2 = 0  // 数値を2で割った余りが0（つまり偶数）ならtrue、そうでなければfalseを返す

// テスト
let result = isEven 12
printfn "%b" result  // 結果を表示

// 2
printf "2022-2: pic uo even from Numbers of List [1,2,3,4,5] --> "
// 偶数のみをフィルターする関数 引数はlst 
// List.filterはリストの各要素に対して条件を適用し、その条件を満たす要素だけを含む新しいリストを作成する関数
let filterEven (lst: int list) =
    List.filter (fun x -> x % 2 = 0) lst

// 整数のリスト
let numbers2 = [1; 2; 3; 4; 5]

// filterEven関数を使用してリストから偶数のみをフィルター
let evenNumbers = filterEven numbers2

// 結果を表示
printfn "%A" evenNumbers