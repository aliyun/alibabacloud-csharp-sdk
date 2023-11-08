// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SearchFormDatasResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDatasResponseBodyData> Data { get; set; }
        public class SearchFormDatasResponseBodyData : TeaModel {
            [NameInMap("CreatedTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            [NameInMap("FormData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("ModelUuid")]
            [Validation(Required=false)]
            public string ModelUuid { get; set; }

            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("ModifierUserId")]
            [Validation(Required=false)]
            public string ModifierUserId { get; set; }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDatasResponseBodyDataModifyUser : TeaModel {
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataModifyUserUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataModifyUserUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("Originator")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDatasResponseBodyDataOriginator : TeaModel {
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataOriginatorUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataOriginatorUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
