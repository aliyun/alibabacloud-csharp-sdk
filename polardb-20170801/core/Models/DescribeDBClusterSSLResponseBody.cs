// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of SSL connection information.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterSSLResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterSSLResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The cluster endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-************</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic rotation of SSL certificates is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enable</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>Disable</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only when the database engine is compatible with PostgreSQL or Oracle syntax.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("SSLAutoRotate")]
            [Validation(Required=false)]
            public string SSLAutoRotate { get; set; }

            /// <summary>
            /// <para>The SSL connection endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-************.mysql.polardb.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("SSLConnectionString")]
            [Validation(Required=false)]
            public string SSLConnectionString { get; set; }

            /// <summary>
            /// <para>Indicates whether SSL encryption is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SSLEnabled")]
            [Validation(Required=false)]
            public string SSLEnabled { get; set; }

            /// <summary>
            /// <para>The certificate validity period. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-13T07:14:22Z</para>
            /// </summary>
            [NameInMap("SSLExpireTime")]
            [Validation(Required=false)]
            public string SSLExpireTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C890995A-CF06-4F4D-8DB8-DD26C2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic rotation of SSL certificates is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>Disable</b>: disabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for PolarDB for MySQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public string SSLAutoRotate { get; set; }

    }

}
