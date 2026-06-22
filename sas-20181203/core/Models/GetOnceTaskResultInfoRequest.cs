// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOnceTaskResultInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the one-time task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9dfa3a7eb9547781632785b49003****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The name of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CLIENT_PROBLEM_CHECK</b>: client troubleshooting task</para>
        /// </description></item>
        /// <item><description><para><b>CLIENT_DEV_OPS</b>: cloud O\&amp;M task</para>
        /// </description></item>
        /// <item><description><para><b>ASSET_SECURITY_CHECK</b>: asset collection task</para>
        /// </description></item>
        /// <item><description><para><b>ASSETS_COLLECTION</b>: asset fingerprint collection task</para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_SCAN</b>: container image scan task</para>
        /// </description></item>
        /// <item><description><para><b>AI_SECURITY_CHECK</b>: AI asset synchronization task</para>
        /// </description></item>
        /// <item><description><para><b>IDC_PROBE_SCAN</b>: IDC probe scan task</para>
        /// </description></item>
        /// <item><description><para><b>ATTACK_SURFACE_SCAN</b>: attack surface and boundary asset scan task</para>
        /// </description></item>
        /// <item><description><para><b>ASSET_EXPOSURE_SCAN</b>: asset exposure scan task</para>
        /// </description></item>
        /// <item><description><para><b>VUL_CHECK_TASK</b>: vulnerability scan task</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSETS_COLLECTION</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CLIENT_PROBLEM_CHECK</b>: client troubleshooting task</para>
        /// </description></item>
        /// <item><description><para><b>CLIENT_DEV_OPS</b>: cloud O\&amp;M task</para>
        /// </description></item>
        /// <item><description><para><b>ASSET_SECURITY_CHECK</b>: asset collection task</para>
        /// </description></item>
        /// <item><description><para><b>ASSETS_COLLECTION</b>: asset fingerprint collection task</para>
        /// </description></item>
        /// <item><description><para><b>IMAGE_SCAN</b>: container image scan task</para>
        /// </description></item>
        /// <item><description><para><b>AI_SECURITY_CHECK</b>: AI asset synchronization task</para>
        /// </description></item>
        /// <item><description><para><b>IDC_PROBE_SCAN</b>: IDC probe scan task</para>
        /// </description></item>
        /// <item><description><para><b>ATTACK_SURFACE_SCAN</b>: attack surface and boundary asset scan task</para>
        /// </description></item>
        /// <item><description><para><b>ASSET_EXPOSURE_SCAN</b>: asset exposure scan task</para>
        /// </description></item>
        /// <item><description><para><b>VUL_CHECK_TASK</b>: vulnerability scan task</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSETS_COLLECTION</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
