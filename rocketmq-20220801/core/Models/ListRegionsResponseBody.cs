// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListRegionsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListRegionsResponseBodyData> Data { get; set; }
        public class ListRegionsResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("regionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("supportRocketmqV4")]
            [Validation(Required=false)]
            public bool? SupportRocketmqV4 { get; set; }

            [NameInMap("supportRocketmqV5")]
            [Validation(Required=false)]
            public bool? SupportRocketmqV5 { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListRegionsResponseBodyDataTags> Tags { get; set; }
            public class ListRegionsResponseBodyDataTags : TeaModel {
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public object TagValue { get; set; }

            }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
