// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the security groups for the endpoint that is used to access the bastion host over a private network.</para>
        /// </summary>
        [NameInMap("ClientSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> ClientSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the O\&amp;M portal of the bastion host to be accessed over a private network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePortalPrivateAccess")]
        [Validation(Required=false)]
        public bool? EnablePortalPrivateAccess { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host to start.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1gh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to which the bastion host is bound.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1aiupc4yjqgmm****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the secondary vSwitch to which the bastion host is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-9dpspfku7gita****</para>
        /// </summary>
        [NameInMap("SlaveVswitchId")]
        [Validation(Required=false)]
        public string SlaveVswitchId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the bastion host is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1xfwzzfti0kjbf****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
