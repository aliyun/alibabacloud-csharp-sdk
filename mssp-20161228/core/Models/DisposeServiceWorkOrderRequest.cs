// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class DisposeServiceWorkOrderRequest : TeaModel {
        /// <summary>
        /// <para>Attachment name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbaa133c-0ac2-489f-9fc8-39f91c2e770c_20230301-20240403-服务工单列表.xlsx</para>
        /// </summary>
        [NameInMap("AttachmentName")]
        [Validation(Required=false)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// <para>End time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-14 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Forward to owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>405639</para>
        /// </summary>
        [NameInMap("ForwardOwnerId")]
        [Validation(Required=false)]
        public string ForwardOwnerId { get; set; }

        /// <summary>
        /// <para>Work order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23172</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Attachment requirement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsAttachment")]
        [Validation(Required=false)]
        public string IsAttachment { get; set; }

        /// <summary>
        /// <para>Work order notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsWorkOrderNotify")]
        [Validation(Required=false)]
        public string IsWorkOrderNotify { get; set; }

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
        /// <para>处理完成</para>
        /// </summary>
        [NameInMap("OperateRemark")]
        [Validation(Required=false)]
        public string OperateRemark { get; set; }

        /// <summary>
        /// <para>Processing type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSED</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>Operator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>396120</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>Start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-02 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Upgrade owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>336333</para>
        /// </summary>
        [NameInMap("UpgradeOwnerId")]
        [Validation(Required=false)]
        public string UpgradeOwnerId { get; set; }

        /// <summary>
        /// <para>Work order details.</para>
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
        /// <para>安全产品配置问题与超量提醒</para>
        /// </summary>
        [NameInMap("WorkOrderName")]
        [Validation(Required=false)]
        public string WorkOrderName { get; set; }

        /// <summary>
        /// <para>Work order status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSED</para>
        /// </summary>
        [NameInMap("WorkOrderStatus")]
        [Validation(Required=false)]
        public string WorkOrderStatus { get; set; }

    }

}
