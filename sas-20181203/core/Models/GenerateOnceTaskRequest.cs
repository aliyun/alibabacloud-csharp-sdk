// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>A JSON string that contains additional parameters for the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:1,&quot;problemType&quot;:&quot;offline&quot;,&quot;uuids&quot;:&quot;inet-795dcad1-360f-49d2-b01e-b7da7f1c****&quot;}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The source that initiated the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The name of the scan task.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_PROBLEM_CHECK</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CLIENT_PROBLEM_CHECK</b>: a client troubleshooting task</para>
        /// </description></item>
        /// <item><description><para><b>CLIENT_DEV_OPS</b>: a cloud DevOps task</para>
        /// </description></item>
        /// <item><description><para><b>ASSET_SECURITY_CHECK</b>: an asset collection task</para>
        /// </description></item>
        /// <item><description><para><b>ASSETS_COLLECTION</b>: an asset fingerprinting task</para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_SCAN</b>: a container image scan task</para>
        /// </description></item>
        /// <item><description><para><b>AI_SECURITY_CHECK</b>: an AI asset synchronization task</para>
        /// </description></item>
        /// <item><description><para><b>IDC_PROBE_SCAN</b>: an IDC probe scan task</para>
        /// </description></item>
        /// <item><description><para><b>ATTACK_SURFACE_SCAN</b>: an attack surface scan task</para>
        /// </description></item>
        /// <item><description><para><b>ASSET_EXPOSURE_SCAN</b>: an asset exposure scan task</para>
        /// </description></item>
        /// <item><description><para><b>VUL_CHECK_TASK</b>: a vulnerability scan task</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_PROBLEM_CHECK</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
