// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGatewaySecretDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the secret of the ASM gateway.</para>
        /// </summary>
        [NameInMap("GatewaySecretDetails")]
        [Validation(Required=false)]
        public List<DescribeGatewaySecretDetailsResponseBodyGatewaySecretDetails> GatewaySecretDetails { get; set; }
        public class DescribeGatewaySecretDetailsResponseBodyGatewaySecretDetails : TeaModel {
            /// <summary>
            /// <para>The time when the certificate expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-03 07:45</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The name of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bookinfo-gateway</para>
            /// </summary>
            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            /// <summary>
            /// <para>The time when the certificate was issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-03 07:45</para>
            /// </summary>
            [NameInMap("IssueTime")]
            [Validation(Required=false)]
            public string IssueTime { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>An error message is returned if the status of the gateway is abnormal. Examples: <c>tls.crt not exist</c>, <c>tls.key not exist</c>, and <c>secret type must be kubernetes.io/tls</c>.</description></item>
            /// <item><description>An empty value is returned if the status of the gateway is normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tls.crt not exist</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The Server Name Indication (SNI) value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.com</para>
            /// </summary>
            [NameInMap("SNI")]
            [Validation(Required=false)]
            public string SNI { get; set; }

            /// <summary>
            /// <para>The name of the secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-secret</para>
            /// </summary>
            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>normal</c></description></item>
            /// <item><description><c>abnormal</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
