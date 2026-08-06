// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The category of the configuration item. The following categories are supported:</para>
        /// <list type="bullet">
        /// <item><description>CommonResourceConfig: common resource configuration.</description></item>
        /// <item><description>DLCAutoRecycle: DLC automatic recycling.</description></item>
        /// <item><description>DLCPriorityConfig: DLC priority settings.</description></item>
        /// <item><description>DSWPriorityConfig: DSW priority settings.</description></item>
        /// <item><description>QuotaMaximumDuration: maximum runtime duration configuration for DLC jobs in a quota.</description></item>
        /// <item><description>CommonTagConfig: tag settings.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonResourceConfig</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The keys of the configuration items. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description>tempStoragePath: the temporary storage path. This ConfigKey can be used only when CategoryName is set to CommonResourceConfig.</description></item>
        /// <item><description>isAutoRecycle: the automatic recycling configuration. This ConfigKey can be used only when CategoryName is set to DLCAutoRecycle.</description></item>
        /// <item><description>priorityConfig: the priority configuration. This ConfigKey can be used only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
        /// <item><description>quotaMaximumDuration: the maximum runtime duration configuration for DLC jobs in a quota. This ConfigKey can be used only when CategoryName is set to QuotaMaximumDuration.</description></item>
        /// <item><description>predefinedTags: the preset tags for the workspace. Resources that are created must include these tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tempStoragePath</para>
        /// </summary>
        [NameInMap("ConfigKeys")]
        [Validation(Required=false)]
        public string ConfigKeys { get; set; }

        /// <summary>
        /// <para>The labels used as filter conditions. Separate multiple conditions with commas. These conditions are evaluated using a logical AND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2=value2</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>Specifies whether to display label information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Display label information.</description></item>
        /// <item><description>false: Do not display label information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public string Verbose { get; set; }

    }

}
