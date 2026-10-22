// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyIPAclConfigRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address restriction configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IPAclConfig")]
        [Validation(Required=false)]
        public SetPolicyIPAclConfigRequestIPAclConfig IPAclConfig { get; set; }
        public class SetPolicyIPAclConfigRequestIPAclConfig : TeaModel {
            /// <summary>
            /// <para>The source IP address restriction mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>black</b>: blacklist mode</description></item>
            /// <item><description><b>white</b>: whitelist mode</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>white</para>
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            /// <summary>
            /// <para>The list of restricted source IP addresses.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When AclType is set to white, the IPs list is required.</description></item>
            /// <item><description>When AclType is set to black but you do not need to set a source IP blacklist, pass an empty list for IPs.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("IPs")]
            [Validation(Required=false)]
            public List<string> IPs { get; set; }

        }

        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the bastion host instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the control policy that you want to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
