// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateCustomEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzjasd****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the access control instance. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. The name can contain digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ext-win-live-17</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether a node automatically joins the cluster and starts providing services after the node is added or recovered.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NodeAutoEnter")]
        [Validation(Required=false)]
        public bool? NodeAutoEnter { get; set; }

        /// <summary>
        /// <para>The IDs of the monitored nodes when RemindUnit (object type) is set to NODE (node). Separate multiple IDs with commas (,). A maximum of 50 nodes can be monitored per rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1l5kfgw8****c3iv</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>To query the metrics of a read-only node in a cloud-native read/write splitting architecture instance, set this parameter to <b>READONLY</b> and specify the <b>NodeId</b> parameter.</para>
        /// <remarks>
        /// <para> In other cases, you do not need to specify this parameter or you can set it to <b>MASTER</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>READONLY</para>
        /// </summary>
        [NameInMap("NodeRole")]
        [Validation(Required=false)]
        public string NodeRole { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which the endpoint resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ndoug37dtwoedlmru0</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
