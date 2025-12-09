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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value. Make sure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <para>The information about the scaled/added node.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<TempModifyDBNodeRequestDBNode> DBNode { get; set; }
        public class TempModifyDBNodeRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The specifications of the scaled/added node.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The specification of the new node must be consistent with the specifications of the original nodes.</para>
            /// </description></item>
            /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view the specifications of the original nodes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.medium</para>
            /// </summary>
            [NameInMap("TargetClass")]
            [Validation(Required=false)]
            public string TargetClass { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which the added node is deployed. It must be the same zone as the original nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The type of configuration change. Set the value to <b>TempUpgrade</b>.</para>
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
        /// <item><description><b>Modify</b>: temporarily upgrades the configuration of the cluster.</description></item>
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
        /// <para>The rollback time of the configuration for the temporary upgrade. Specify the time in the ISO 8601 standard in the YYYY-MM-DD hh:mm:ss format.</para>
        /// <remarks>
        /// <para> The rollback time cannot be 1 hour earlier than the current time and cannot be later than one day before the time when the cluster expires.</para>
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
