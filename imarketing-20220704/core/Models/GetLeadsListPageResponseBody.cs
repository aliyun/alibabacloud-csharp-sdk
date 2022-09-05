// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetLeadsListPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLeadsListPageResponseBodyData Data { get; set; }
        public class GetLeadsListPageResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetLeadsListPageResponseBodyDataList> List { get; set; }
            public class GetLeadsListPageResponseBodyDataList : TeaModel {
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                [NameInMap("ContentId")]
                [Validation(Required=false)]
                public long? ContentId { get; set; }

                [NameInMap("CreativeId")]
                [Validation(Required=false)]
                public int? CreativeId { get; set; }

                [NameInMap("CreativeName")]
                [Validation(Required=false)]
                public string CreativeName { get; set; }

                [NameInMap("LeadsDetail")]
                [Validation(Required=false)]
                public string LeadsDetail { get; set; }

                [NameInMap("SerialId")]
                [Validation(Required=false)]
                public long? SerialId { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public GetLeadsListPageResponseBodyDataPageInfo PageInfo { get; set; }
            public class GetLeadsListPageResponseBodyDataPageInfo : TeaModel {
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalNumber")]
                [Validation(Required=false)]
                public int? TotalNumber { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
