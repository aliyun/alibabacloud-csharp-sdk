// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7B7D598-B080-5C8E-AA35-D43EC0D5F886</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyResult> Result { get; set; }
        public class DescribeRegionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The endpoint of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>endpoint</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The ID of the region. Valid values:</para>
            /// <para>cn-hangzhou: China (Hangzhou)</para>
            /// <para>cn-shanghai: China (Shanghai)</para>
            /// <para>cn-qingdao: China (Qingdao)</para>
            /// <para>cn-beijing: China (Beijing)</para>
            /// <para>cn-zhangjiakou: China (Zhangjiakou)</para>
            /// <para>cn-shenzhen: China (Shenzhen)</para>
            /// <para>ap-southeast-1: Singapore (Singapore)</para>
            /// <para>cn-internal: Internal Center</para>
            /// <para>cn-zhangbei-in: Internal Center (Zhangjiakou)</para>
            /// <para>us-west-1-in: Internal Center (US)</para>
            /// <para>rus-west-1-in: Internal Center (Russia)</para>
            /// <para>cn-daily: Daily Environment</para>
            /// <para>cn-test: Joint Debugging</para>
            /// <para>pre-hangzhou: China (Hangzhou)-Staging</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
