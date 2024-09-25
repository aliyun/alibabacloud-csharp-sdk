// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SSL connections.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterSSLResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterSSLResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-************</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <para>The SSL connection string.</para>
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
            /// <item><description><b>Enabled</b>: SSL is enabled.</description></item>
            /// <item><description><b>Disable</b>: SSL is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SSLEnabled")]
            [Validation(Required=false)]
            public string SSLEnabled { get; set; }

            /// <summary>
            /// <para>The time when the server certificate expires. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-13T07:14:22Z</para>
            /// </summary>
            [NameInMap("SSLExpireTime")]
            [Validation(Required=false)]
            public string SSLExpireTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <item><description><b>Enable</b>: The feature is enabled.</description></item>
        /// <item><description><b>Disable</b>: The feature is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only for a PolarDB for MySQL cluster.</para>
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
