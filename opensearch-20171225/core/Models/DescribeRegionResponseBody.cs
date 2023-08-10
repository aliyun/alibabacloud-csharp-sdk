// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeRegionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result that was returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeRegionResponseBodyResult Result { get; set; }
        public class DescribeRegionResponseBodyResult : TeaModel {
            /// <summary>
            /// The configurations.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, object> Config { get; set; }

            /// <summary>
            /// The ID of the region. Valid values:
            /// 
            /// cn-hangzhou: China (Hangzhou)
            /// 
            /// cn-shanghai: China (Shanghai)
            /// 
            /// cn-qingdao: China (Qingdao)
            /// 
            /// cn-beijing: China (Beijing)
            /// 
            /// cn-zhangjiakou: China (Zhangjiakou)
            /// 
            /// cn-shenzhen: China (Shenzhen)
            /// 
            /// ap-southeast-1: Singapore (Singapore)
            /// 
            /// cn-internal: Internal Center
            /// 
            /// cn-zhangbei-in: Internal Center (Zhangjiakou)
            /// 
            /// us-west-1-in: Internal Center (US)
            /// 
            /// rus-west-1-in: Internal Center (Russia)
            /// 
            /// cn-daily: Daily Environment
            /// 
            /// cn-test: Joint Debugging
            /// 
            /// pre-hangzhou: China (Hangzhou)-Staging
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
