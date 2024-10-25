// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetDeviceInternetPortResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. The value is the ID of the server or container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5sadvk2xnylvra9kyejcnevi6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network mapping information about the instance.</para>
        /// </summary>
        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public List<GetDeviceInternetPortResponseBodyNetworkInfo> NetworkInfo { get; set; }
        public class GetDeviceInternetPortResponseBodyNetworkInfo : TeaModel {
            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.105.62.120</para>
            /// </summary>
            [NameInMap("ExternalIp")]
            [Validation(Required=false)]
            public string ExternalIp { get; set; }

            /// <summary>
            /// <para>The external port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// <para>The internal IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.49</para>
            /// </summary>
            [NameInMap("InternalIp")]
            [Validation(Required=false)]
            public string InternalIp { get; set; }

            /// <summary>
            /// <para>The internal port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020/2025</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

            /// <summary>
            /// <para>The status of the external port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36311833-83FC-57C3-A7DD-768F61F65555</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
