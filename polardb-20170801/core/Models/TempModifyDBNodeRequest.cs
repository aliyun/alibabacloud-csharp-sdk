// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class TempModifyDBNodeRequest : TeaModel {
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique token for each request. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The information about the nodes to upgrade or add.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<TempModifyDBNodeRequestDBNode> DBNode { get; set; }
        public class TempModifyDBNodeRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The specifications of the node to upgrade or add.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>When you add a node, the node specifications must be the same as the specifications of the existing nodes.</para>
            /// </description></item>
            /// <item><description><para>For more information about the specifications of existing cluster nodes, see <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.medium</para>
            /// </summary>
            [NameInMap("TargetClass")]
            [Validation(Required=false)]
            public string TargetClass { get; set; }

            /// <summary>
            /// <para>The zone for the new node. The zone must be the same as the zone of the existing nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The modification type. The value is fixed to <b>TempUpgrade</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TempUpgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Modify</b>: temporary upgrade</para>
        /// </description></item>
        /// <item><description><para><b>Add</b>: temporarily add a node</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modify</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The time to revert the temporary upgrade. The format is YYYY-MM-DD hh:mm:ss.</para>
        /// <remarks>
        /// <para>The revert time must be at least 1 hour later than the current time. It must also be at least 1 day before the cluster expires.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-23 18:16:00</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

    }

}
