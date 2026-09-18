// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class RobotCallRequest : TeaModel {
        /// <summary>
        /// <para>The called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****2204</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The caller number for the outbound call. You can view this number on the <a href="https://dyvmsnext.console.aliyun.com/number/list/normal">Real Number Management</a> page of the voice messaging service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132****0849</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the number status identification feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Disabled.</description></item>
        /// <item><description><b>true</b>: Enabled.<remarks>
        /// <para>After this feature is enabled, the reason why a call is not answered is recorded.</para>
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
        /// <para>The ID reserved for the caller. This ID is returned to the caller through a receipt message. The value is 1 to 15 bytes in length.</para>
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
        /// <para>The parameter list of the robot in JSON format. The total length cannot exceed 512 bytes. You can view the parameters on the <a href="https://aiccs.console.aliyun.com/patter/list">Script Management</a> &gt; <b>Details</b> &gt; <b>Input/Output Parameters</b> page or by calling the <a href="https://help.aliyun.com/document_detail/2717999.html">ListRobotParams</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;name&quot;: &quot;Zhang San&quot;,
        ///   &quot;age&quot;: &quot;25&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Specifies whether to record the call. Valid values:</para>
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
        /// <para>The robot ID, which is the script ID. You can view approved script IDs on the <a href="https://aiccs.console.aliyun.com/patter/list">Script Management</a> page.</para>
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
