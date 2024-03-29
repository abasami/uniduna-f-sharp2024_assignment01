printfn "the first assignment- FUJIWARA AYA"
// 1
printfn "1:"
// 整数のリストを二乗する関数
let squareList (lst: int list) =
    List.map (fun x -> x * x) lst

// 整数のリスト
let numbers = [1; 2; 3; 4; 5]

// squareList関数を使用してリストの各要素を二乗
let squaredNumbers = squareList numbers

// 結果を表示
printfn "%A" squaredNumbers

// 2
printfn "2:"
// 偶数のみをフィルターする関数
let filterEven (lst: int list) =
    List.filter (fun x -> x % 2 = 0) lst

// 整数のリスト
let numbers2 = [1; 2; 3; 4; 5]

// filterEven関数を使用してリストから偶数のみをフィルター
let evenNumbers = filterEven numbers2

// 結果を表示
printfn "%A" evenNumbers

//3
printfn "3:"
// 正の数値の合計を計算する関数
let sumPositive (lst: int list) =
    List.filter (fun x -> x > 0) lst
    |> List.sum

// 整数のリスト
let numbers3 = [1; -2; 3; -4; 5]

// sumPositive関数を使用してリストから正の数値の合計を計算
let sum = sumPositive numbers3

// 結果を表示
printfn "%A" sum

//4
printfn "4:"
let capitalize2 (str: string) =
    match str with
    | "" -> ""
    | _ -> str.[0..].ToUpper()

let capitalizeNames2 names2 =
    names2 |> List.map capitalize2
let names2 = ["alice"; "BOB"; "Charlie"]
let capitalizedNames2 = capitalizeNames2 names2

// 結果を出力します。
printfn "%A" capitalizedNames2

//5
printfn "5:"
let filterByLength (list:string list) (n:int) =
    list |> List.filter (fun str -> str.Length > n)
let names3 = ["Alice"; "Bob"; "Charlie"]
let filteredNames = filterByLength names3 5
//filteredNames |> List.iter (printfn "%s")
// 結果を出力します。
printfn "%A" filteredNames

//6
printfn "6:"
// 割り切れる数値の数を計算する関数
let countDivisors (n: int) (divisors: int list) =
    List.filter (fun x -> n % x = 0) divisors
    |> List.length

// 整数と約数のリスト
let number6 = 12
let divisors = [1; 2; 3; 4; 5; 6]

// countDivisors関数を使用して割り切れる数値の数を計算
let count = countDivisors number6 divisors

// 結果を表示
printfn "%A" count

//7
printfn "7:"
// 指定した要素が見つかるすべてのインデックスを取得する関数
let findIndices (lst: 'a list) (item: 'a) =
    lst
    |> List.mapi (fun i x -> if x = item then Some i else None)
    |> List.choose id

// 整数のリスト
let numbers7 = [1; 2; 3; 2; 4; 2; 5]

// findIndices関数を使用してリストから指定した要素が見つかるすべてのインデックスを取得
let indices = findIndices numbers7 2

// 結果を表示
printfn "%A" indices

//8
// 'concatLongStrings'という関数を定義します。この関数は整数と文字列のリストを引数に取ります。
let concatLongStrings (n:int) strings =
    // 'List.filter'関数を使用して、長さが'n'より大きい文字列だけを抽出します。
    // 'String.concat ""'を使用して、抽出した文字列を連結します。
    strings
    |> List.filter (fun (s:string) -> s.Length > n)
    |> String.concat ""

// 長さが3より大きい文字列だけを連結したい文字列のリストを定義します。
let strings = ["Hello"; "World"; "F#"; "is"; "awesome"]

// 'concatLongStrings'関数を使用して、長さが3より大きい文字列だけを連結し、その結果を'longString'に格納します。
let longString = concatLongStrings 3 strings

// 結果を出力します。
printfn "%s" longString


//9
printfn "9:"
// valueが最大値を持つタプルを見つける関数
let findMaxTuple (lst: (string * int) list) =
    List.maxBy snd lst

// (id, value)の形式を持つタプルのリスト
let tuples = [("a", 1); ("b", 2); ("c", 3)]

// findMaxTuple関数を使用してvalueが最大値を持つタプルを見つける
let maxTuple = findMaxTuple tuples

// 結果を表示
printfn "%A" maxTuple

//10
printfn "10:"
// 各要素とその出現回数を含むタプルのリストを作成する関数
let countOccurrences (lst: 'a list) =
    lst
    |> List.groupBy id
    |> List.map (fun (key, values) -> (key, List.length values))

// 繰り返す可能性のある要素のリスト
let items = ["apple"; "banana"; "apple"; "orange"; "banana"; "banana"]

// countOccurrences関数を使用して各要素とその出現回数を含むタプルのリストを作成
let counts = countOccurrences items

// 結果を表示
printfn "%A" counts

//11
printfn "11:"
// 交通信号のDUを定義
type TrafficLight =
    | Red
    | Yellow
    | Green

// 交通信号の状態を受け取り次の状態を返す関数
let nextLightState currentLightState =
    match currentLightState with
    | Red -> Green
    | Yellow -> Red
    | Green -> Yellow

// 交通信号の状態をテスト
let lightState = Red
let nextState = nextLightState lightState

// 結果を表示
printfn "The next state after %A is %A" lightState nextState

//12
printfn "12:"
// 基本的な算術演算のDUを作成
type ArithmeticOperation =
    | Add
    | Subtract
    | Multiply
    | Divide

// 2つの数値と演算を受け取り、数値に対して演算を実行する関数
let performOperation op x y =
    match op with
    | Add -> x + y
    | Subtract -> x - y
    | Multiply -> x * y
    | Divide -> x / y

// 演算をテスト
let operation = Add
let result = performOperation operation 5 3

// 結果を表示
printfn "The result of the operation is %A" result

//13
printfn "13:"
// 異なる形状のDUを定義
type Shape =
    | Circle of radius: float
    | Rectangle of width: float * height: float
    | Square of side: float

// 与えられた形状の面積を計算する関数
let calculateArea shape =
    match shape with
    | Circle(radius) -> System.Math.PI * radius * radius
    | Rectangle(width, height) -> width * height
    | Square(side) -> side * side

// 形状とその面積をテスト
let shape = Circle(5.0)
let area = calculateArea shape

// 結果を表示
printfn "The area of the shape is %A" area

//14
printfn "14:"
// 温度のスケールのDUを定義
type Temperature =
    | Celsius of float
    | Fahrenheit of float

// 温度をスケール間で変換する関数
let convertTemperature temp =
    match temp with
    | Celsius(c) -> Fahrenheit(c * 9.0 / 5.0 + 32.0)
    | Fahrenheit(f) -> Celsius((f - 32.0) * 5.0 / 9.0)

// 温度とその変換をテスト
let temperature = Celsius(20.0)
let converted = convertTemperature temperature

// 結果を表示
printfn "The converted temperature is %A" converted

//15
printfn "15:"
// 簡略化されたJSON値を表すDUを作成
type JsonValue =
    | JsonObject of Map<string, JsonValue>
    | JsonArray of JsonValue list
    | JsonString of string
    | JsonNumber of float
    | JsonBoolean of bool

// JSON値をきれいに印刷する関数
let rec prettyPrint json =
    match json with
    | JsonObject(map) ->
        let contents =
            map
            |> Map.toList
            |> List.map (fun (key, value) -> sprintf "\"%s\": %s" key (prettyPrint value))
            |> String.concat ", "
        sprintf "{ %s }" contents
    | JsonArray(list) ->
        let contents = list |> List.map prettyPrint |> String.concat ", "
        sprintf "[ %s ]" contents
    | JsonString(str) -> sprintf "\"%s\"" str
    | JsonNumber(num) -> sprintf "%f" num
    | JsonBoolean(b) -> sprintf "%b" b

// JSON値とそのきれいな印刷をテスト
let json = JsonObject(Map.ofList [("name", JsonString("Alice")); ("age", JsonNumber(20.0))])
let pretty = prettyPrint json

// 結果を表示
printfn "%s" pretty

//16
printfn "16:"
// n番目のフィボナッチ数を計算する再帰関数
let rec fibonacci n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> fibonacci (n - 1) + fibonacci (n - 2)

// フィボナッチ数をテスト
let n = 10
let fib = fibonacci n

// 結果を表示
printfn "The %dth Fibonacci number is %d" n fib

//17
printfn "17:"
// 再帰的な二分探索アルゴリズム
let rec binarySearch (arr: 'a list) (target: 'a) =
    let midIndex = arr.Length / 2
    match arr with
    | [] -> false
    | _ when arr.[midIndex] = target -> true
    | _ when arr.[midIndex] < target -> binarySearch arr.[midIndex + 1 ..] target
    | _ -> binarySearch arr.[.. midIndex - 1] target

// 二分探索をテスト
let numbers17 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
let target = 5
let found = binarySearch numbers17 target

// 結果を表示
printfn "Is the target %d found in the list? %b" target found

//18
printfn "18:"
// マージソートのヘルパー関数
let rec merge left right =
    match left, right with
    | [], _ -> right
    | _, [] -> left
    | x :: xs, y :: ys ->
        if x <= y then x :: merge xs right
        else y :: merge left ys

// 再帰的なマージソート関数
let rec mergeSort lst =
    let len = List.length lst
    if len <= 1 then lst
    else
        let mid = len / 2
        let left = List.take mid lst
        let right = List.skip mid lst
        merge (mergeSort left) (mergeSort right)

// マージソートをテスト
let numbers18 = [5; 3; 8; 4; 2; 6; 7; 1; 9; 0]
let sorted = mergeSort numbers18

// 結果を表示
printfn "%A" sorted

//19
printfn "19:"
// 二分木のDUを定義
type BinaryTree =
    | Node of BinaryTree * BinaryTree
    | Leaf

// 二分木の深さを計算する再帰関数
let rec depth tree =
    match tree with
    | Leaf -> 0
    | Node(left, right) -> 1 + max (depth left) (depth right)

// 二分木とその深さをテスト
let tree = Node(Node(Leaf, Node(Leaf, Leaf)), Node(Leaf, Leaf))
let treeDepth = depth tree

// 結果を表示
printfn "The depth of the tree is %d" treeDepth

//20
printfn "20:"
// 与えられた文字列が回文であるかどうかをチェックする再帰関数
let rec isPalindrome (str: string) =
    if str.Length <= 1 then true
    else
        str.[0] = str.[str.Length - 1] && isPalindrome (str.[1 .. str.Length - 2])

// 回文チェックをテスト
let word = "racecar"
let palindromeCheck = isPalindrome word

// 結果を表示
printfn "Is the word '%s' a palindrome? %b" word palindromeCheck