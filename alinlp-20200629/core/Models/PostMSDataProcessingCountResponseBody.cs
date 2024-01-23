// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class PostMSDataProcessingCountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PostMSDataProcessingCountResponseBodyData Data { get; set; }
        public class PostMSDataProcessingCountResponseBodyData : TeaModel {
            [NameInMap("DataProcessedStatuses")]
            [Validation(Required=false)]
            public List<PostMSDataProcessingCountResponseBodyDataDataProcessedStatuses> DataProcessedStatuses { get; set; }
            public class PostMSDataProcessingCountResponseBodyDataDataProcessedStatuses : TeaModel {
                [NameInMap("ChunkNum")]
                [Validation(Required=false)]
                public string ChunkNum { get; set; }

                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("ErrorDataList")]
                [Validation(Required=false)]
                public List<PostMSDataProcessingCountResponseBodyDataDataProcessedStatusesErrorDataList> ErrorDataList { get; set; }
                public class PostMSDataProcessingCountResponseBodyDataDataProcessedStatusesErrorDataList : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                }

                [NameInMap("OpStatus")]
                [Validation(Required=false)]
                public Dictionary<string, int?> OpStatus { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VersionValue")]
                [Validation(Required=false)]
                public string VersionValue { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
