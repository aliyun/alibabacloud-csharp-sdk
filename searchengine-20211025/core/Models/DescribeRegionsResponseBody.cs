// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyResult> Result { get; set; }
        public class DescribeRegionsResponseBodyResult : TeaModel {
            /// <summary>
            /// The endpoint of the region.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

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
