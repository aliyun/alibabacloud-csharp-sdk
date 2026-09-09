// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLastOnceTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The source from which the task was added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console_batch</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The task name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: client problem troubleshooting task</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: cloud O&amp;M task</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: asset collection task</description></item>
        /// <item><description><b>ASSETS_COLLECTION</b>: Asset Fingerprints collection task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: container image scan task</description></item>
        /// <item><description><b>AI_SECURITY_CHECK</b>: AI asset synchronization task</description></item>
        /// <item><description><b>IDC_PROBE_SCAN</b>: IDC probe scan task</description></item>
        /// <item><description><b>ATTACK_SURFACE_SCAN</b>: attack surface boundary asset scan task</description></item>
        /// <item><description><b>ASSET_EXPOSURE_SCAN</b>: asset exposure scan task</description></item>
        /// <item><description><b>VUL_CHECK_TASK</b>: vulnerability scanning task</description></item>
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
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: client problem troubleshooting task</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: cloud O&amp;M task</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: asset collection task</description></item>
        /// <item><description><b>ASSETS_COLLECTION</b>: Asset Fingerprints collection task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: container image scan task</description></item>
        /// <item><description><b>AI_SECURITY_CHECK</b>: AI asset synchronization task</description></item>
        /// <item><description><b>IDC_PROBE_SCAN</b>: IDC probe scan task</description></item>
        /// <item><description><b>ATTACK_SURFACE_SCAN</b>: attack surface boundary asset scan task</description></item>
        /// <item><description><b>ASSET_EXPOSURE_SCAN</b>: asset exposure scan task</description></item>
        /// <item><description><b>VUL_CHECK_TASK</b>: vulnerability scanning task</description></item>
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
