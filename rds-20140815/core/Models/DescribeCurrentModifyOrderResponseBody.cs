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
            /// <para>The instance family.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the instance type. Unit: cores.</para>
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
            /// <para>The effective period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Immediate</b> (default): The specification change takes effect immediately.</description></item>
            /// <item><description><b>MaintainTime</b>: The specification change takes effect during the maintenance window. For more information, see <a href="https://help.aliyun.com/document_detail/610402.html">ModifyDBInstanceMaintainTime</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaintainTime</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The mark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Mark")]
            [Validation(Required=false)]
            public string Mark { get; set; }

            /// <summary>
            /// <para>The memory capacity for the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed,Scheduled,Running,Cancelling,Canceled,Waiting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

            /// <summary>
            /// <para>The target instance type for the specification change.</para>
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
