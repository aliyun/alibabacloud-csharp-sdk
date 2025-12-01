// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class CreateServiceWorkOrderRequest : TeaModel {
        /// <summary>
        /// <para>Creator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>426556</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>Customer ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1477832102462645</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <para>Duration in days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DurationDay")]
        [Validation(Required=false)]
        public string DurationDay { get; set; }

        /// <summary>
        /// <para>Attachment requirement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsAttachment")]
        [Validation(Required=false)]
        public string IsAttachment { get; set; }

        /// <summary>
        /// <para>Is milestone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsMilestone")]
        [Validation(Required=false)]
        public string IsMilestone { get; set; }

        /// <summary>
        /// <para>Whether a reminder is needed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsWorkOrderNotify")]
        [Validation(Required=false)]
        public string IsWorkOrderNotify { get; set; }

        /// <summary>
        /// <para>Number of days for advance notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NotifyDay")]
        [Validation(Required=false)]
        public string NotifyDay { get; set; }

        /// <summary>
        /// <para>Notification ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NotifyId")]
        [Validation(Required=false)]
        public long? NotifyId { get; set; }

        /// <summary>
        /// <para>Operation remarks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newly built</para>
        /// </summary>
        [NameInMap("OperateRemark")]
        [Validation(Required=false)]
        public string OperateRemark { get; set; }

        /// <summary>
        /// <para>Operation type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>Operator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>426556</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1734788109000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Work order details.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;questionDetail&quot;:&quot;测试工单&quot;,&quot;answerDetail&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("WorkOrderDetail")]
        [Validation(Required=false)]
        public string WorkOrderDetail { get; set; }

        /// <summary>
        /// <para>Work order name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Delivery task of safety monthly report</para>
        /// </summary>
        [NameInMap("WorkOrderName")]
        [Validation(Required=false)]
        public string WorkOrderName { get; set; }

        /// <summary>
        /// <para>Work order source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Work order migration</para>
        /// </summary>
        [NameInMap("WorkOrderSource")]
        [Validation(Required=false)]
        public string WorkOrderSource { get; set; }

        /// <summary>
        /// <para>Work order status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNPROCESSED</para>
        /// </summary>
        [NameInMap("WorkOrderStatus")]
        [Validation(Required=false)]
        public string WorkOrderStatus { get; set; }

        /// <summary>
        /// <para>Work order type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTH_REPORT</para>
        /// </summary>
        [NameInMap("WorkOrderType")]
        [Validation(Required=false)]
        public string WorkOrderType { get; set; }

    }

}
