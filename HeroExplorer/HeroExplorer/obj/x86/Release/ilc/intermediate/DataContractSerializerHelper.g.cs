using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 483
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                7, // array length: 7
                821, // index: 821, string: "attributionHTML"
                837, // index: 837, string: "attributionText"
                853, // index: 853, string: "code"
                858, // index: 858, string: "copyright"
                868, // index: 868, string: "data"
                873, // index: 873, string: "etag"
                878, // index: 878, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                5, // array length: 5
                885, // index: 885, string: "count"
                891, // index: 891, string: "limit"
                897, // index: 897, string: "offset"
                904, // index: 904, string: "results"
                912, // index: 912, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                11, // array length: 11
                918, // index: 918, string: "comics"
                925, // index: 925, string: "description"
                937, // index: 937, string: "events"
                944, // index: 944, string: "id"
                947, // index: 947, string: "modified"
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                973, // index: 973, string: "series"
                980, // index: 980, string: "stories"
                988, // index: 988, string: "thumbnail"
                998, // index: 998, string: "urls"
                11, // array length: 11
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1003, // index: 1003, string: "available"
                1013, // index: 1013, string: "collectionURI"
                1027, // index: 1027, string: "items"
                1033, // index: 1033, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1003, // index: 1003, string: "available"
                1013, // index: 1013, string: "collectionURI"
                1027, // index: 1027, string: "items"
                1033, // index: 1033, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1003, // index: 1003, string: "available"
                1013, // index: 1013, string: "collectionURI"
                1027, // index: 1027, string: "items"
                1033, // index: 1033, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1003, // index: 1003, string: "available"
                1013, // index: 1013, string: "collectionURI"
                1027, // index: 1027, string: "items"
                1033, // index: 1033, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                3, // array length: 3
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                1042, // index: 1042, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1047, // index: 1047, string: "extension"
                1057, // index: 1057, string: "large"
                1063, // index: 1063, string: "path"
                1068, // index: 1068, string: "small"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                1042, // index: 1042, string: "type"
                1074, // index: 1074, string: "url"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                7, // array length: 7
                821, // index: 821, string: "attributionHTML"
                837, // index: 837, string: "attributionText"
                853, // index: 853, string: "code"
                858, // index: 858, string: "copyright"
                868, // index: 868, string: "data"
                873, // index: 873, string: "etag"
                878, // index: 878, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                5, // array length: 5
                885, // index: 885, string: "count"
                891, // index: 891, string: "limit"
                897, // index: 897, string: "offset"
                904, // index: 904, string: "results"
                912, // index: 912, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                29, // array length: 29
                -1, // string: null
                630, // index: 630, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                630, // index: 630, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                29, // array length: 29
                1078, // index: 1078, string: "characters"
                1089, // index: 1089, string: "collectedIssues"
                1105, // index: 1105, string: "collections"
                1117, // index: 1117, string: "creators"
                1126, // index: 1126, string: "dates"
                925, // index: 925, string: "description"
                1132, // index: 1132, string: "diamondCode"
                1144, // index: 1144, string: "digitalId"
                1154, // index: 1154, string: "ean"
                937, // index: 937, string: "events"
                1158, // index: 1158, string: "format"
                944, // index: 944, string: "id"
                1165, // index: 1165, string: "images"
                1172, // index: 1172, string: "isbn"
                1177, // index: 1177, string: "issn"
                1182, // index: 1182, string: "issueNumber"
                947, // index: 947, string: "modified"
                1194, // index: 1194, string: "pageCount"
                1204, // index: 1204, string: "prices"
                961, // index: 961, string: "resourceURI"
                973, // index: 973, string: "series"
                980, // index: 980, string: "stories"
                1211, // index: 1211, string: "textObjects"
                988, // index: 988, string: "thumbnail"
                1223, // index: 1223, string: "title"
                1229, // index: 1229, string: "upc"
                998, // index: 998, string: "urls"
                1233, // index: 1233, string: "variantDescription"
                1252, // index: 1252, string: "variants"
                29, // array length: 29
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1003, // index: 1003, string: "available"
                1013, // index: 1013, string: "collectionURI"
                1027, // index: 1027, string: "items"
                1033, // index: 1033, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                4, // array length: 4
                1003, // index: 1003, string: "available"
                1013, // index: 1013, string: "collectionURI"
                1027, // index: 1027, string: "items"
                1033, // index: 1033, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                3, // array length: 3
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                1261, // index: 1261, string: "role"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                1266, // index: 1266, string: "date"
                1042, // index: 1042, string: "type"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                1047, // index: 1047, string: "extension"
                1063, // index: 1063, string: "path"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                1271, // index: 1271, string: "price"
                1042, // index: 1042, string: "type"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                3, // array length: 3
                1277, // index: 1277, string: "language"
                1286, // index: 1286, string: "text"
                1042, // index: 1042, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                2, // array length: 2
                956, // index: 956, string: "name"
                961, // index: 961, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
                276  // index: 276, string: "http://schemas.datacontract.org/2004/07/HeroExplorer.Models"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=78
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.CharacterDataWrapper, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.CharacterDataContainer, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral" +
                                ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                "")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comics, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Events, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.SeriesList, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Stories, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Thumbnail, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicDataWrapper, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicDataContainer, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral" +
                                ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                "")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Characters, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Creators, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                "a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 242, // 0xf2
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=25
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // CharacterDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 255, // CharacterDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 255, // CharacterDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.CharacterDataWrapper, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.CharacterDataWrapper, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 9,
                    MemberNamesListIndex = 11,
                    MemberNamespacesListIndex = 19,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 336, // CharacterDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 336, // CharacterDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 336, // CharacterDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.CharacterDataContainer, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.CharacterDataContainer, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 27,
                    ContractNamespacesListIndex = 33,
                    MemberNamesListIndex = 35,
                    MemberNamespacesListIndex = 41,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 376, // Character
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 376, // Character
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 376, // Character
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 59,
                    MemberNamesListIndex = 61,
                    MemberNamespacesListIndex = 73,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 386, // Comics
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 386, // Comics
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 386, // Comics
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comics, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comics, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 85,
                    ContractNamespacesListIndex = 90,
                    MemberNamesListIndex = 92,
                    MemberNamespacesListIndex = 97,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 406, // Comic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 406, // Comic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 406, // Comic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 102,
                    ContractNamespacesListIndex = 105,
                    MemberNamesListIndex = 107,
                    MemberNamespacesListIndex = 110,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 412, // Events
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 412, // Events
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 412, // Events
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Events, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Events, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 118,
                    MemberNamesListIndex = 120,
                    MemberNamespacesListIndex = 125,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 432, // Event
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 432, // Event
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 432, // Event
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 130,
                    ContractNamespacesListIndex = 133,
                    MemberNamesListIndex = 135,
                    MemberNamespacesListIndex = 138,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // SeriesList
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 438, // SeriesList
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 438, // SeriesList
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.SeriesList, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.SeriesList, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 141,
                    ContractNamespacesListIndex = 146,
                    MemberNamesListIndex = 148,
                    MemberNamespacesListIndex = 153,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 463, // Series
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 463, // Series
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 463, // Series
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 158,
                    ContractNamespacesListIndex = 161,
                    MemberNamesListIndex = 163,
                    MemberNamespacesListIndex = 166,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 470, // Stories
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 470, // Stories
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 470, // Stories
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Stories, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Stories, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 169,
                    ContractNamespacesListIndex = 174,
                    MemberNamesListIndex = 176,
                    MemberNamespacesListIndex = 181,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 491, // Story
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 491, // Story
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 491, // Story
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 186,
                    ContractNamespacesListIndex = 190,
                    MemberNamesListIndex = 192,
                    MemberNamespacesListIndex = 196,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 497, // Thumbnail
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 497, // Thumbnail
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 497, // Thumbnail
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Thumbnail, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Thumbnail, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 200,
                    ContractNamespacesListIndex = 205,
                    MemberNamesListIndex = 207,
                    MemberNamespacesListIndex = 212,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 518, // Url
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 518, // Url
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 518, // Url
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 217,
                    ContractNamespacesListIndex = 220,
                    MemberNamesListIndex = 222,
                    MemberNamespacesListIndex = 225,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 522, // ComicDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 522, // ComicDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 522, // ComicDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicDataWrapper, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicDataWrapper, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 228,
                    ContractNamespacesListIndex = 236,
                    MemberNamesListIndex = 238,
                    MemberNamespacesListIndex = 246,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 539, // ComicDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 539, // ComicDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 539, // ComicDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicDataContainer, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicDataContainer, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 254,
                    ContractNamespacesListIndex = 260,
                    MemberNamesListIndex = 262,
                    MemberNamespacesListIndex = 268,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 575, // ComicBook
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 575, // ComicBook
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 575, // ComicBook
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 274,
                    ContractNamespacesListIndex = 304,
                    MemberNamesListIndex = 306,
                    MemberNamespacesListIndex = 336,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 585, // Characters
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 585, // Characters
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 585, // Characters
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Characters, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Characters, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 366,
                    ContractNamespacesListIndex = 371,
                    MemberNamesListIndex = 373,
                    MemberNamespacesListIndex = 378,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 609, // Item2
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 609, // Item2
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 609, // Item2
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 383,
                    ContractNamespacesListIndex = 386,
                    MemberNamesListIndex = 388,
                    MemberNamespacesListIndex = 391,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 688, // Creators
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 688, // Creators
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 688, // Creators
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Creators, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Creators, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 394,
                    ContractNamespacesListIndex = 399,
                    MemberNamesListIndex = 401,
                    MemberNamespacesListIndex = 406,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 709, // Item
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 709, // Item
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 709, // Item
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 411,
                    ContractNamespacesListIndex = 415,
                    MemberNamesListIndex = 417,
                    MemberNamespacesListIndex = 421,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 726, // Date
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 726, // Date
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 726, // Date
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 425,
                    ContractNamespacesListIndex = 428,
                    MemberNamesListIndex = 430,
                    MemberNamespacesListIndex = 433,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 744, // Image
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 744, // Image
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 744, // Image
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 436,
                    ContractNamespacesListIndex = 439,
                    MemberNamesListIndex = 441,
                    MemberNamespacesListIndex = 444,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 763, // Price
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 763, // Price
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 763, // Price
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 447,
                    ContractNamespacesListIndex = 450,
                    MemberNamesListIndex = 452,
                    MemberNamespacesListIndex = 455,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 787, // TextObject
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 787, // TextObject
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 787, // TextObject
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 458,
                    ContractNamespacesListIndex = 462,
                    MemberNamesListIndex = 464,
                    MemberNamespacesListIndex = 468,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 813, // Variant
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 813, // Variant
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 813, // Variant
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 472,
                    ContractNamespacesListIndex = 475,
                    MemberNamesListIndex = 477,
                    MemberNamespacesListIndex = 480,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=16
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 359, // ArrayOfCharacter
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 359, // ArrayOfCharacter
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 359, // ArrayOfCharacter
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 376, // Character
                    KeyNameIndex = -1,
                    ItemNameIndex = 376, // Character
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Character, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 393, // ArrayOfComic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 393, // ArrayOfComic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 393, // ArrayOfComic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 406, // Comic
                    KeyNameIndex = -1,
                    ItemNameIndex = 406, // Comic
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Comic, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 419, // ArrayOfEvent
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 419, // ArrayOfEvent
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 419, // ArrayOfEvent
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 432, // Event
                    KeyNameIndex = -1,
                    ItemNameIndex = 432, // Event
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Event, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 449, // ArrayOfSeries
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 449, // ArrayOfSeries
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 449, // ArrayOfSeries
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 463, // Series
                    KeyNameIndex = -1,
                    ItemNameIndex = 463, // Series
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Series, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 478, // ArrayOfStory
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 478, // ArrayOfStory
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 478, // ArrayOfStory
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 491, // Story
                    KeyNameIndex = -1,
                    ItemNameIndex = 491, // Story
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Story, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 507, // ArrayOfUrl
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 507, // ArrayOfUrl
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 507, // ArrayOfUrl
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 518, // Url
                    KeyNameIndex = -1,
                    ItemNameIndex = 518, // Url
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Url, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 558, // ArrayOfComicBook
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 558, // ArrayOfComicBook
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 558, // ArrayOfComicBook
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 575, // ComicBook
                    KeyNameIndex = -1,
                    ItemNameIndex = 575, // ComicBook
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.ComicBook, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 596, // ArrayOfItem2
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 596, // ArrayOfItem2
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 596, // ArrayOfItem2
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 609, // Item2
                    KeyNameIndex = -1,
                    ItemNameIndex = 609, // Item2
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item2, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 615, // ArrayOfanyType
                        NamespaceIndex = 630, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 615, // ArrayOfanyType
                        StableNameNamespaceIndex = 630, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 615, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 630, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 697, // ArrayOfItem
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 697, // ArrayOfItem
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 697, // ArrayOfItem
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 709, // Item
                    KeyNameIndex = -1,
                    ItemNameIndex = 709, // Item
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Item, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 714, // ArrayOfDate
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 714, // ArrayOfDate
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 714, // ArrayOfDate
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 726, // Date
                    KeyNameIndex = -1,
                    ItemNameIndex = 726, // Date
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Date, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 731, // ArrayOfImage
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 731, // ArrayOfImage
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 731, // ArrayOfImage
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 744, // Image
                    KeyNameIndex = -1,
                    ItemNameIndex = 744, // Image
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Image, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 750, // ArrayOfPrice
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 750, // ArrayOfPrice
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 750, // ArrayOfPrice
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 763, // Price
                    KeyNameIndex = -1,
                    ItemNameIndex = 763, // Price
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Price, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 769, // ArrayOfTextObject
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 769, // ArrayOfTextObject
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 769, // ArrayOfTextObject
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 787, // TextObject
                    KeyNameIndex = -1,
                    ItemNameIndex = 787, // TextObject
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.TextObject, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 798, // ArrayOfVariant
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        StableNameIndex = 798, // ArrayOfVariant
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        TopLevelElementNameIndex = 798, // ArrayOfVariant
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/HeroExplorer.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 813, // Variant
                    KeyNameIndex = -1,
                    ItemNameIndex = 813, // Variant
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("HeroExplorer.Models.Variant, HeroExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 615, // ArrayOfanyType
                        NamespaceIndex = 630, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 615, // ArrayOfanyType
                        StableNameNamespaceIndex = 630, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 615, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 630, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=41
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteCharacterDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadCharacterDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteCharacterDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadCharacterDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type12.WriteArrayOfCharacterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type11.ReadArrayOfCharacterFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type13.ReadArrayOfCharacterFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteCharacterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadCharacterFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type21.WriteComicsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type20.ReadComicsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type26.WriteArrayOfComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type25.ReadArrayOfComicFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type27.ReadArrayOfComicFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type31.WriteComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type30.ReadComicFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type35.WriteEventsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type34.ReadEventsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfEventFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfEventFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadEventFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type49.WriteSeriesListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type48.ReadSeriesListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type54.WriteArrayOfSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type53.ReadArrayOfSeriesFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type55.ReadArrayOfSeriesFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type59.WriteSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type58.ReadSeriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type63.WriteStoriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type62.ReadStoriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type68.WriteArrayOfStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type67.ReadArrayOfStoryFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type69.ReadArrayOfStoryFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type73.WriteStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type72.ReadStoryFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type77.WriteThumbnailToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type76.ReadThumbnailFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type82.WriteArrayOfUrlToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type81.ReadArrayOfUrlFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type83.ReadArrayOfUrlFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type87.WriteUrlToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type86.ReadUrlFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type91.WriteComicDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type90.ReadComicDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type95.WriteComicDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type94.ReadComicDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type100.WriteArrayOfComicBookToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type99.ReadArrayOfComicBookFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type101.ReadArrayOfComicBookFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type105.WriteComicBookToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type104.ReadComicBookFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type109.WriteCharactersToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type108.ReadCharactersFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type114.WriteArrayOfItem2ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type113.ReadArrayOfItem2FromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type115.ReadArrayOfItem2FromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type119.WriteItem2ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type118.ReadItem2FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type124.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type123.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type125.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type129.WriteCreatorsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type128.ReadCreatorsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type134.WriteArrayOfItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type133.ReadArrayOfItemFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type135.ReadArrayOfItemFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type139.WriteItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type138.ReadItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type144.WriteArrayOfDateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type143.ReadArrayOfDateFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type145.ReadArrayOfDateFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type149.WriteDateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type148.ReadDateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type154.WriteArrayOfImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type153.ReadArrayOfImageFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type155.ReadArrayOfImageFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type159.WriteImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type158.ReadImageFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 71,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type164.WriteArrayOfPriceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type163.ReadArrayOfPriceFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type165.ReadArrayOfPriceFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 72,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type169.WritePriceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type168.ReadPriceFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 73,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type174.WriteArrayOfTextObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type173.ReadArrayOfTextObjectFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type175.ReadArrayOfTextObjectFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 74,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type179.WriteTextObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type178.ReadTextObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 75,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type184.WriteArrayOfVariantToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type183.ReadArrayOfVariantFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type185.ReadArrayOfVariantFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 76,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type189.WriteVariantToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type188.ReadVariantFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 77,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type194.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type193.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type195.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','C','h','a','r','a','c','t','e','r','D','a','t','a','W','r',
            'a','p','p','e','r','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r',
            'a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','H','e','r','o','E','x','p','l','o','r','e','r','.','M',
            'o','d','e','l','s','\0','C','h','a','r','a','c','t','e','r','D','a','t','a','C','o','n','t','a','i','n','e','r','\0','A',
            'r','r','a','y','O','f','C','h','a','r','a','c','t','e','r','\0','C','h','a','r','a','c','t','e','r','\0','C','o','m','i',
            'c','s','\0','A','r','r','a','y','O','f','C','o','m','i','c','\0','C','o','m','i','c','\0','E','v','e','n','t','s','\0','A',
            'r','r','a','y','O','f','E','v','e','n','t','\0','E','v','e','n','t','\0','S','e','r','i','e','s','L','i','s','t','\0','A',
            'r','r','a','y','O','f','S','e','r','i','e','s','\0','S','e','r','i','e','s','\0','S','t','o','r','i','e','s','\0','A','r',
            'r','a','y','O','f','S','t','o','r','y','\0','S','t','o','r','y','\0','T','h','u','m','b','n','a','i','l','\0','A','r','r',
            'a','y','O','f','U','r','l','\0','U','r','l','\0','C','o','m','i','c','D','a','t','a','W','r','a','p','p','e','r','\0','C',
            'o','m','i','c','D','a','t','a','C','o','n','t','a','i','n','e','r','\0','A','r','r','a','y','O','f','C','o','m','i','c',
            'B','o','o','k','\0','C','o','m','i','c','B','o','o','k','\0','C','h','a','r','a','c','t','e','r','s','\0','A','r','r','a',
            'y','O','f','I','t','e','m','2','\0','I','t','e','m','2','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0',
            'h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2',
            '0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','C','r',
            'e','a','t','o','r','s','\0','A','r','r','a','y','O','f','I','t','e','m','\0','I','t','e','m','\0','A','r','r','a','y','O',
            'f','D','a','t','e','\0','D','a','t','e','\0','A','r','r','a','y','O','f','I','m','a','g','e','\0','I','m','a','g','e','\0',
            'A','r','r','a','y','O','f','P','r','i','c','e','\0','P','r','i','c','e','\0','A','r','r','a','y','O','f','T','e','x','t',
            'O','b','j','e','c','t','\0','T','e','x','t','O','b','j','e','c','t','\0','A','r','r','a','y','O','f','V','a','r','i','a',
            'n','t','\0','V','a','r','i','a','n','t','\0','a','t','t','r','i','b','u','t','i','o','n','H','T','M','L','\0','a','t','t',
            'r','i','b','u','t','i','o','n','T','e','x','t','\0','c','o','d','e','\0','c','o','p','y','r','i','g','h','t','\0','d','a',
            't','a','\0','e','t','a','g','\0','s','t','a','t','u','s','\0','c','o','u','n','t','\0','l','i','m','i','t','\0','o','f','f',
            's','e','t','\0','r','e','s','u','l','t','s','\0','t','o','t','a','l','\0','c','o','m','i','c','s','\0','d','e','s','c','r',
            'i','p','t','i','o','n','\0','e','v','e','n','t','s','\0','i','d','\0','m','o','d','i','f','i','e','d','\0','n','a','m','e',
            '\0','r','e','s','o','u','r','c','e','U','R','I','\0','s','e','r','i','e','s','\0','s','t','o','r','i','e','s','\0','t','h',
            'u','m','b','n','a','i','l','\0','u','r','l','s','\0','a','v','a','i','l','a','b','l','e','\0','c','o','l','l','e','c','t',
            'i','o','n','U','R','I','\0','i','t','e','m','s','\0','r','e','t','u','r','n','e','d','\0','t','y','p','e','\0','e','x','t',
            'e','n','s','i','o','n','\0','l','a','r','g','e','\0','p','a','t','h','\0','s','m','a','l','l','\0','u','r','l','\0','c','h',
            'a','r','a','c','t','e','r','s','\0','c','o','l','l','e','c','t','e','d','I','s','s','u','e','s','\0','c','o','l','l','e',
            'c','t','i','o','n','s','\0','c','r','e','a','t','o','r','s','\0','d','a','t','e','s','\0','d','i','a','m','o','n','d','C',
            'o','d','e','\0','d','i','g','i','t','a','l','I','d','\0','e','a','n','\0','f','o','r','m','a','t','\0','i','m','a','g','e',
            's','\0','i','s','b','n','\0','i','s','s','n','\0','i','s','s','u','e','N','u','m','b','e','r','\0','p','a','g','e','C','o',
            'u','n','t','\0','p','r','i','c','e','s','\0','t','e','x','t','O','b','j','e','c','t','s','\0','t','i','t','l','e','\0','u',
            'p','c','\0','v','a','r','i','a','n','t','D','e','s','c','r','i','p','t','i','o','n','\0','v','a','r','i','a','n','t','s',
            '\0','r','o','l','e','\0','d','a','t','e','\0','p','r','i','c','e','\0','l','a','n','g','u','a','g','e','\0','t','e','x','t',
            '\0'};
    }
}
