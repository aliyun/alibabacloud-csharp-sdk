// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of regions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyData> Data { get; set; }
        public class DescribeRegionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The display name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Beijing)</para>
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6BD6C79-32B1-5D7E-A89A-93C5A6B7xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
