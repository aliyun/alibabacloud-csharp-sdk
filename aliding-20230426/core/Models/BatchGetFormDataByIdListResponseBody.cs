// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class BatchGetFormDataByIdListResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchGetFormDataByIdListResponseBodyResult> Result { get; set; }
        public class BatchGetFormDataByIdListResponseBodyResult : TeaModel {
            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("FormData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultModifyUser ModifyUser { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultModifyUser : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultModifyUserName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultModifyUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Originator")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultOriginator Originator { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultOriginator : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultOriginatorName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
