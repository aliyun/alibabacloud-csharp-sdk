// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCustomCallTaggingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomCallTaggingResponseBodyData Data { get; set; }
        public class ListCustomCallTaggingResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCustomCallTaggingResponseBodyDataList> List { get; set; }
            public class ListCustomCallTaggingResponseBodyDataList : TeaModel {
                public List<ListCustomCallTaggingResponseBodyDataListCallTagList> CallTagList { get; set; }
                public class ListCustomCallTaggingResponseBodyDataListCallTagList : TeaModel {
                    public string InstanceId { get; set; }
                    public string TagName { get; set; }
                }
                public string Creator { get; set; }
                public string Description { get; set; }
                public string InstanceId { get; set; }
                public string Number { get; set; }
                public string UpdateTime { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
