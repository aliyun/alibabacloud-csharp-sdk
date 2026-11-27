// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>The caller number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130****0000</para>
        /// </summary>
        [NameInMap("Ani")]
        [Validation(Required=false)]
        public string Ani { get; set; }

        /// <summary>
        /// <para>The current page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of department IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DepartmentIdList")]
        [Validation(Required=false)]
        public string DepartmentIdList { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571456****</para>
        /// </summary>
        [NameInMap("Dnis")]
        [Validation(Required=false)]
        public string Dnis { get; set; }

        /// <summary>
        /// <para>The call end reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("EndReasonList")]
        [Validation(Required=false)]
        public string EndReasonList { get; set; }

        /// <summary>
        /// <para>Instance ID of the AICCS instance. You can obtain instance ID in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a> by choosing Instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the outbound task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120001</para>
        /// </summary>
        [NameInMap("OutboundTaskId")]
        [Validation(Required=false)]
        public string OutboundTaskId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of priorities. Valid values: <b>1</b> to <b>100</b>. A larger value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,5]</para>
        /// </summary>
        [NameInMap("PriorityList")]
        [Validation(Required=false)]
        public string PriorityList { get; set; }

        /// <summary>
        /// <para>The ID of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1212</para>
        /// </summary>
        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public string ServicerId { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Doe</para>
        /// </summary>
        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

        /// <summary>
        /// <para>The ID of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1004849</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <para>The ID of the skill group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("SkillGroup")]
        [Validation(Required=false)]
        public string SkillGroup { get; set; }

        /// <summary>
        /// <para>The list of task statuses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Not started.</description></item>
        /// <item><description><b>2</b>: In progress.</description></item>
        /// <item><description><b>3</b>: Paused.</description></item>
        /// <item><description><b>4</b>: Expired.</description></item>
        /// <item><description><b>5</b>: Completed.</description></item>
        /// <item><description><b>6</b>: Deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,5]</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// <para>The ID of the task detail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
