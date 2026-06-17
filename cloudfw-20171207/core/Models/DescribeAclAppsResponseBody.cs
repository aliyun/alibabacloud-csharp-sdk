// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ACL applications.</para>
        /// </summary>
        [NameInMap("AclApps")]
        [Validation(Required=false)]
        public List<DescribeAclAppsResponseBodyAclApps> AclApps { get; set; }
        public class DescribeAclAppsResponseBodyAclApps : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is common. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: common</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: not common</para>
            /// </description></item>
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Popular")]
            [Validation(Required=false)]
            public int? Popular { get; set; }

            /// <summary>
            /// <para>The protocols supported by the application.</para>
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Low</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Medium</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: High</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>Indicates whether the application supports <c>FQDN</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: No</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Yes</para>
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
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
