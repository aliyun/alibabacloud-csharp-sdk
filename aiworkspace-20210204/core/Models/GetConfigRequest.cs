// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The category of the configuration item. The following categories are supported:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig: common resource configuration</description></item>
        /// <item><description>DLCAutoRecycle: DLC automatic reclamation</description></item>
        /// <item><description>DLCPriorityConfig: DLC priority settings</description></item>
        /// <item><description>DSWPriorityConfig: DSW priority settings</description></item>
        /// <item><description>QuotaMaximumDuration: maximum runtime duration configuration for DLC jobs in a quota</description></item>
        /// <item><description>CommonTagConfig: tag settings</description></item>
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
        /// <item><description>tempStoragePath: the temporary storage path. This key is valid only when CategoryName is set to CommonResourceConfig.</description></item>
        /// <item><description>isAutoRecycle: the automatic reclamation configuration. This key is valid only when CategoryName is set to DLCAutoRecycle.</description></item>
        /// <item><description>priorityConfig: the priority configuration. This key is valid only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
        /// <item><description>quotaMaximumDuration: the maximum runtime duration configuration for DLC jobs in a quota. This key is valid only when CategoryName is set to QuotaMaximumDuration.</description></item>
        /// <item><description>predefinedTags: the preset tags for the workspace. Resources created in the workspace must include these tags.</description></item>
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
