// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListDetectionsResponseBody : TeaModel {
        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<ListDetectionsResponseBodyErrors> Errors { get; set; }
        public class ListDetectionsResponseBodyErrors : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDetectionsResponseBodyData Data { get; set; }
        public class ListDetectionsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListDetectionsResponseBodyDataItems> Items { get; set; }
            public class ListDetectionsResponseBodyDataItems : TeaModel {
                public string Status { get; set; }
                public string DepartmentName { get; set; }
                public List<ListDetectionsResponseBodyDataItemsTasks> Tasks { get; set; }
                public class ListDetectionsResponseBodyDataItemsTasks : TeaModel {
                    public string Status { get; set; }
                    public string VideoMetaUrl { get; set; }
                    public string CreatedAt { get; set; }
                    public string Id { get; set; }
                    public string VideoUrl { get; set; }
                }
                public string RecordingType { get; set; }
                public string CreatedAt { get; set; }
                public string DepartmentId { get; set; }
                public string Id { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
            }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
