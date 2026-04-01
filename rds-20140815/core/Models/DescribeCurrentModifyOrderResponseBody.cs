// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCurrentModifyOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The specification change order.</para>
        /// </summary>
        [NameInMap("ModifyOrder")]
        [Validation(Required=false)]
        public List<DescribeCurrentModifyOrderResponseBodyModifyOrder> ModifyOrder { get; set; }
        public class DescribeCurrentModifyOrderResponseBodyModifyOrder : TeaModel {
            /// <summary>
            /// <para>The instance family of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The number of CPU cores that are supported by the instance type. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-cn-nwy39qeys0003r</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <para>The effective time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Immediate</b>: This is the default value.</description></item>
            /// <item><description><b>MaintainTime</b>: The effective time is within the maintenance window. For more information, see <a href="https://help.aliyun.com/document_detail/610402.html">ModifyDBInstanceMaintainTime</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaintainTime</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJ2IjoibWV0YS5rOHMuaW8vdjEiLCJydiI6MTg2MjEwOTkwLCJzdGFydCI6InNob3BpZnktdXNlci1jb3JlXHUwMDAwIn0</para>
            /// </summary>
            [NameInMap("Mark")]
            [Validation(Required=false)]
            public string Mark { get; set; }

            /// <summary>
            /// <para>The memory capacity that is supported by the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed,Scheduled,Running,Cancelling,Canceled,Waiting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage capacity of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

            /// <summary>
            /// <para>The new instance type of the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.x2.medium.2c</para>
            /// </summary>
            [NameInMap("TargetDBInstanceClass")]
            [Validation(Required=false)]
            public string TargetDBInstanceClass { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C87415BE-F5AB-55A4-A60E-A0A329EAF2A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
