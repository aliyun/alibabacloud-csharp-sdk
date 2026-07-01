// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The security group attribute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>snapshotPolicyIds: queries the snapshot policies associated with the security group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshotPolicyIds</para>
        /// </summary>
        [NameInMap("Attribute")]
        [Validation(Required=false)]
        public string Attribute { get; set; }

        /// <summary>
        /// <para>The direction of the security group rule. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>egress: outbound.</description></item>
        /// <item><description>ingress: inbound.</description></item>
        /// <item><description>all: both inbound and outbound.</description></item>
        /// </list>
        /// <para>Default value: all.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 10.</description></item>
        /// <item><description>Maximum value: 1000.</description></item>
        /// </list>
        /// <para>Default value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous call. You do not need to set this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The network type of the security group rule.</para>
        /// <list type="bullet">
        /// <item><description><para>For security groups in a VPC, the only valid value is intranet (default), which indicates internal network.</para>
        /// <remarks>
        /// <para>If you set this parameter to internet or leave it empty, the value is automatically set to intranet.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>Valid values for security groups in the classic network:</para>
        /// <list type="bullet">
        /// <item><description>internet (default): Internet.</description></item>
        /// <item><description>intranet: internal network.<remarks>
        /// <para>The classic network feature has been offline. For details, see <a href="https://help.aliyun.com/document_detail/2833134.html">Retirement announcement</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("NicType")]
        [Validation(Required=false)]
        public string NicType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the security group. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1gxw6bznjjvhu3****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
