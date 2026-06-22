// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLastOnceTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The source that initiated the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console_batch</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The name of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CLIENT_PROBLEM_CHECK</c>: client troubleshooting task</para>
        /// </description></item>
        /// <item><description><para><c>CLIENT_DEV_OPS</c>: O\&amp;M task</para>
        /// </description></item>
        /// <item><description><para><c>ASSET_SECURITY_CHECK</c>: asset collection task</para>
        /// </description></item>
        /// <item><description><para><c>ASSETS_COLLECTION</c>: asset fingerprint collection task</para>
        /// </description></item>
        /// <item><description><para><c>IMAGE_SCAN</c>: container image scan task</para>
        /// </description></item>
        /// <item><description><para><c>AI_SECURITY_CHECK</c>: AI asset synchronization task</para>
        /// </description></item>
        /// <item><description><para><c>IDC_PROBE_SCAN</c>: IDC probe scan task</para>
        /// </description></item>
        /// <item><description><para><c>ATTACK_SURFACE_SCAN</c>: attack surface boundary asset scan task</para>
        /// </description></item>
        /// <item><description><para><c>ASSET_EXPOSURE_SCAN</c>: asset exposure scan task</para>
        /// </description></item>
        /// <item><description><para><c>VUL_CHECK_TASK</c>: vulnerability scan task</para>
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
        /// <item><description><para><c>CLIENT_PROBLEM_CHECK</c>: client troubleshooting task</para>
        /// </description></item>
        /// <item><description><para><c>CLIENT_DEV_OPS</c>: O\&amp;M task</para>
        /// </description></item>
        /// <item><description><para><c>ASSET_SECURITY_CHECK</c>: asset collection task</para>
        /// </description></item>
        /// <item><description><para><c>ASSETS_COLLECTION</c>: asset fingerprint collection task</para>
        /// </description></item>
        /// <item><description><para><c>IMAGE_SCAN</c>: container image scan task</para>
        /// </description></item>
        /// <item><description><para><c>AI_SECURITY_CHECK</c>: AI asset synchronization task</para>
        /// </description></item>
        /// <item><description><para><c>IDC_PROBE_SCAN</c>: IDC probe scan task</para>
        /// </description></item>
        /// <item><description><para><c>ATTACK_SURFACE_SCAN</c>: attack surface boundary asset scan task</para>
        /// </description></item>
        /// <item><description><para><c>ASSET_EXPOSURE_SCAN</c>: asset exposure scan task</para>
        /// </description></item>
        /// <item><description><para><c>VUL_CHECK_TASK</c>: vulnerability scan task</para>
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
