// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class ListDigitalHumanMaterialsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDigitalHumanMaterialsResponseBodyData> Data { get; set; }
        public class ListDigitalHumanMaterialsResponseBodyData : TeaModel {
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<ListDigitalHumanMaterialsResponseBodyDataComponents> Components { get; set; }
            public class ListDigitalHumanMaterialsResponseBodyDataComponents : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public string Ext { get; set; }

                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                [NameInMap("Files")]
                [Validation(Required=false)]
                public Dictionary<string, object> Files { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("Files")]
            [Validation(Required=false)]
            public Dictionary<string, object> Files { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SortOrder")]
            [Validation(Required=false)]
            public int? SortOrder { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Pages")]
        [Validation(Required=false)]
        public int? Pages { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
