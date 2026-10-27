// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The extended information field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:1,&quot;problemType&quot;:&quot;offline&quot;,&quot;uuids&quot;:&quot;inet-795dcad1-360f-49d2-b01e-b7da7f1c****&quot;}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The source of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The node name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: Client troubleshooting node.</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: Cloud O&amp;M node.</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: Asset collection node.</description></item>
        /// <item><description><b>ASSETS_COLLECTION</b>: Asset Fingerprints collection node.</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: Container image scan node.</description></item>
        /// <item><description><b>AI_SECURITY_CHECK</b>: AI asset synchronization node.</description></item>
        /// <item><description><b>IDC_PROBE_SCAN</b>: IDC probe scan node.</description></item>
        /// <item><description><b>ATTACK_SURFACE_SCAN</b>: Attack surface border asset scan node.</description></item>
        /// <item><description><b>ASSET_EXPOSURE_SCAN</b>: Asset exposure scan node.</description></item>
        /// <item><description><b>VUL_CHECK_TASK</b>: Vulnerability scanning node.</description></item>
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
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: Client troubleshooting node.</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: Cloud O&amp;M node.</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: Asset collection node.</description></item>
        /// <item><description><b>ASSETS_COLLECTION</b>: Asset Fingerprints collection node.</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: Container image scan node.</description></item>
        /// <item><description><b>AI_SECURITY_CHECK</b>: AI asset synchronization node.</description></item>
        /// <item><description><b>IDC_PROBE_SCAN</b>: IDC probe scan node.</description></item>
        /// <item><description><b>ATTACK_SURFACE_SCAN</b>: Attack surface border asset scan node.</description></item>
        /// <item><description><b>ASSET_EXPOSURE_SCAN</b>: Asset exposure scan node.</description></item>
        /// <item><description><b>VUL_CHECK_TASK</b>: Vulnerability scanning node.</description></item>
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
