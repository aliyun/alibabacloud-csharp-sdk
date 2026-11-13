// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of access control applications.</para>
        /// </summary>
        [NameInMap("AclApps")]
        [Validation(Required=false)]
        public List<DescribeAclAppsResponseBodyAclApps> AclApps { get; set; }
        public class DescribeAclAppsResponseBodyAclApps : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Specifies whether the application is common. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Common.</para>
            /// </description></item>
            /// <item><description><para>0: Uncommon.</para>
            /// </description></item>
            /// <item><description><para>Empty (default): All.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Popular")]
            [Validation(Required=false)]
            public int? Popular { get; set; }

            /// <summary>
            /// <para>The list of protocol types.</para>
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// <para>The risk assessment level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Low-risk.</description></item>
            /// <item><description><b>2</b>: Medium-risk.</description></item>
            /// <item><description><b>3</b>: High-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>Specifies whether <b>FQDN</b> is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Not supported.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportFqdn")]
            [Validation(Required=false)]
            public int? SupportFqdn { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9063AB86-6FFA-5B2D-A16D-697C966D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
