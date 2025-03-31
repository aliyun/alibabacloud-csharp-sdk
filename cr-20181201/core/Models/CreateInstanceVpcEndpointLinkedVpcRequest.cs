// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateInstanceVpcEndpointLinkedVpcRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically create Alibaba Cloud DNS PrivateZone records. Valid values:</para>
        /// <remarks>
        /// <para> If you enable automatic creation of PrivateZone records, a PrivateZone record is automatically created when you associate a VPC with the instance.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCreateDNSRecordInPvzt")]
        [Validation(Required=false)]
        public bool? EnableCreateDNSRecordInPvzt { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the module that you want to access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Registry</c>: image repositories.</description></item>
        /// <item><description><c>Chart</c>: Helm charts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Registry</para>
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6pa68zxnnlc48dd****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is associated with the specified VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6u0kn8x2gbzxfn2****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
