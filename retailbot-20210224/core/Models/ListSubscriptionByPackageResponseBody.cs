// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListSubscriptionByPackageResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public ListSubscriptionByPackageResponseBodyPageData PageData { get; set; }
        public class ListSubscriptionByPackageResponseBodyPageData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListSubscriptionByPackageResponseBodyPageDataData> Data { get; set; }
            public class ListSubscriptionByPackageResponseBodyPageDataData : TeaModel {
                public string PackageCode { get; set; }
                public string PackageVersion { get; set; }
                public string RobotCode { get; set; }
            }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
