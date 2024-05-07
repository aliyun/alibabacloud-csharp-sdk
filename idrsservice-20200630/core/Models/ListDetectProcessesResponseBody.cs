// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListDetectProcessesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDetectProcessesResponseBodyData Data { get; set; }
        public class ListDetectProcessesResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListDetectProcessesResponseBodyDataItems> Items { get; set; }
            public class ListDetectProcessesResponseBodyDataItems : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ContentAt")]
                [Validation(Required=false)]
                public string ContentAt { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("Draft")]
                [Validation(Required=false)]
                public string Draft { get; set; }

                [NameInMap("DraftAt")]
                [Validation(Required=false)]
                public string DraftAt { get; set; }

                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// ID
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NewVersion")]
                [Validation(Required=false)]
                public bool? NewVersion { get; set; }

                [NameInMap("Published")]
                [Validation(Required=false)]
                public bool? Published { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
