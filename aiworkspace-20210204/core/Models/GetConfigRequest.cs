// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The classification of the configuration item. The following classifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>CommonResourceConfig: common resource configurations</para>
        /// </description></item>
        /// <item><description><para>DLCAutoRecycle: automatic DLC resource recycling</para>
        /// </description></item>
        /// <item><description><para>DLCPriorityConfig: DLC priority settings</para>
        /// </description></item>
        /// <item><description><para>DSWPriorityConfig: DSW priority settings</para>
        /// </description></item>
        /// <item><description><para>QuotaMaximumDuration: the maximum runtime of a DLC task for a quota</para>
        /// </description></item>
        /// <item><description><para>CommonTagConfig: tag settings</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The key of the configuration item. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>tempStoragePath: the temporary storage path. This key applies only when CategoryName is set to CommonResourceConfig.</para>
        /// </description></item>
        /// <item><description><para>isAutoRecycle: the automatic recycling configuration. This key applies only when CategoryName is set to DLCAutoRecycle.</para>
        /// </description></item>
        /// <item><description><para>priorityConfig: the priority configuration. This key applies only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</para>
        /// </description></item>
        /// <item><description><para>quotaMaximumDuration: the maximum runtime of a DLC task for a quota. This key applies only when CategoryName is set to QuotaMaximumDuration.</para>
        /// </description></item>
        /// <item><description><para>predefinedTags: the predefined tags for the workspace. Resources that you create must have tags.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tempStoragePath</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>The value of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://***</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public string Verbose { get; set; }

    }

}
