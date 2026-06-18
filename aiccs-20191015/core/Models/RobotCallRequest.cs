// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class RobotCallRequest : TeaModel {
        /// <summary>
        /// <para>Called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****2204</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>Outbound caller number. View it in the Voice Service <a href="https://dyvmsnext.console.aliyun.com/number/list/normal">Real Number Management</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132****0849</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>Whether to enable the number status detection identity. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (Default Value): Disable.  </description></item>
        /// <item><description><b>true</b>: Enable.  <remarks>
        /// <para>When enabled, the reason for unanswered calls will be recorded.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// <para>An ID reserved for the caller. This ID will be returned to the caller through the receipt message. It must be 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222356****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Parameter list for the robot, in JSON format. The total length must not exceed 512 bytes. You can view the parameters in <a href="https://aiccs.console.aliyun.com/patter/list">Script Management</a> &gt; <b>Details</b> &gt; <b>Input Parameters</b>, or by using the <a href="https://help.aliyun.com/document_detail/2717999.html">ListRobotParams</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;name&quot;: &quot;张三&quot;,
        ///   &quot;age&quot;: &quot;25&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Whether to record the call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Do not record.</description></item>
        /// <item><description><b>true</b>: Record.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecordFlag")]
        [Validation(Required=false)]
        public bool? RecordFlag { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Robot ID, which is the script ID. View the reviewed and approved script ID in the <a href="https://aiccs.console.aliyun.com/patter/list">Script Management</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000035******</para>
        /// </summary>
        [NameInMap("RobotId")]
        [Validation(Required=false)]
        public long? RobotId { get; set; }

    }

}
