// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProxyServiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProxyServiceResponseBodyData Data { get; set; }
        public class DescribeProxyServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-05T08:23:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentEndpointNum")]
            [Validation(Required=false)]
            public long? CurrentEndpointNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EndpointNumQuota")]
            [Validation(Required=false)]
            public long? EndpointNumQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2123-07-05T16:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>proxy-3t****zrieasg</para>
            /// </summary>
            [NameInMap("ProxyClusterId")]
            [Validation(Required=false)]
            public string ProxyClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("ProxyMode")]
            [Validation(Required=false)]
            public string ProxyMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ProxyServiceVersion")]
            [Validation(Required=false)]
            public string ProxyServiceVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4.3.1.0-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("ProxyVersion")]
            [Validation(Required=false)]
            public string ProxyVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("UnitNumLimit")]
            [Validation(Required=false)]
            public long? UnitNumLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4C8GB</para>
            /// </summary>
            [NameInMap("UnitSpec")]
            [Validation(Required=false)]
            public string UnitSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-e,cn-shanghai-f</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
