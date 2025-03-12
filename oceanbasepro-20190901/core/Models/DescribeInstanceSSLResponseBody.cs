// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The SSL setting of the OceanBase cluster instance.</para>
        /// </summary>
        [NameInMap("InstanceSSL")]
        [Validation(Required=false)]
        public DescribeInstanceSSLResponseBodyInstanceSSL InstanceSSL { get; set; }
        public class DescribeInstanceSSLResponseBodyInstanceSSL : TeaModel {
            /// <summary>
            /// <para>The status of automatic update of SSL certificates. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>CLOSE: The automatic update of SSL certificates is disabled. </description></item>
            /// <item><description>OPEN: The automatic update of SSL certificates is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN</para>
            /// </summary>
            [NameInMap("AutoUpdate")]
            [Validation(Required=false)]
            public string AutoUpdate { get; set; }

            /// <summary>
            /// <para>The URL of the certificate authority (CA) node.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx">https://xxxx</a></para>
            /// </summary>
            [NameInMap("CaUrl")]
            [Validation(Required=false)]
            public string CaUrl { get; set; }

            /// <summary>
            /// <para>The operation to modify the SSL status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>open: Enable SSL encryption.</para>
            /// </description></item>
            /// <item><description><para>update: Update the CA certificate.</para>
            /// </description></item>
            /// <item><description><para>close: Disable SSL encryption.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN</para>
            /// </summary>
            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public string EnableSSL { get; set; }

            /// <summary>
            /// <para>The forced enabling status of SSL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOSE</para>
            /// </summary>
            [NameInMap("ForceSSL")]
            [Validation(Required=false)]
            public string ForceSSL { get; set; }

            /// <summary>
            /// <para>Indicates whether SSL can be forcibly enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceSSLSupport")]
            [Validation(Required=false)]
            public bool? ForceSSLSupport { get; set; }

            /// <summary>
            /// <para>The ID of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The SSL status of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The validity period of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-20 07:55:03.0</para>
            /// </summary>
            [NameInMap("ValidPeriod")]
            [Validation(Required=false)]
            public string ValidPeriod { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-xxxx-xxxx-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
