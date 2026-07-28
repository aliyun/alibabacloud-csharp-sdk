// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the instance for which you want to query authorization relationships.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>InstanceType</b> is set to <b>VBR</b>, set this parameter to the VBR instance ID.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceType</b> is set to <b>VPC</b>, set this parameter to the VPC-connected instance ID.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of instance for which you want to query authorization relationships. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VBR</b>: Virtual Border Router (VBR) instance. Queries the VPC-connected instances that have granted authorization to the VBR instance.</description></item>
        /// <item><description><b>VPC</b>: virtual private cloud (VPC) instance. Queries the VBR instances to which the VPC-connected instance has granted authorization.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR instance for which you want to query authorization relationships.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>InstanceType</b> is set to <b>VBR</b>, this parameter is required.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceType</b> is set to <b>VPC</b>, this parameter is not required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
