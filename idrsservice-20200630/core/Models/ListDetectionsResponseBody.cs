// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListDetectionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDetectionsResponseBodyData Data { get; set; }
        public class ListDetectionsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListDetectionsResponseBodyDataItems> Items { get; set; }
            public class ListDetectionsResponseBodyDataItems : TeaModel {
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("DepartmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// ID
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("RecordingType")]
                [Validation(Required=false)]
                public string RecordingType { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<ListDetectionsResponseBodyDataItemsTasks> Tasks { get; set; }
                public class ListDetectionsResponseBodyDataItemsTasks : TeaModel {
                    [NameInMap("CreatedAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("VideoMetaUrl")]
                    [Validation(Required=false)]
                    public string VideoMetaUrl { get; set; }

                    [NameInMap("VideoUrl")]
                    [Validation(Required=false)]
                    public string VideoUrl { get; set; }

                }

            }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<ListDetectionsResponseBodyErrors> Errors { get; set; }
        public class ListDetectionsResponseBodyErrors : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
