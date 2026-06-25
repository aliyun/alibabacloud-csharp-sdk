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
        /// <item><description><para>CommonResourceConfig: The common resource configuration.</para>
        /// </description></item>
        /// <item><description><para>DLCAutoRecycle: The automatic recycling configuration for DLC.</para>
        /// </description></item>
        /// <item><description><para>DLCPriorityConfig: The priority configuration for DLC.</para>
        /// </description></item>
        /// <item><description><para>DSWPriorityConfig: The priority configuration for DSW.</para>
        /// </description></item>
        /// <item><description><para>QuotaMaximumDuration: The configuration for the maximum runtime of a DLC task in a quota.</para>
        /// </description></item>
        /// <item><description><para>CommonTagConfig: The label configuration.</para>
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
        /// <item><description><para>tempStoragePath: The path for temporary storage. This key is valid only when CategoryName is set to CommonResourceConfig.</para>
        /// </description></item>
        /// <item><description><para>isAutoRecycle: The automatic recycling configuration. This key is valid only when CategoryName is set to DLCAutoRecycle.</para>
        /// </description></item>
        /// <item><description><para>priorityConfig: The priority configuration. This key is valid only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</para>
        /// </description></item>
        /// <item><description><para>quotaMaximumDuration: The configuration for the maximum runtime of a DLC task in a quota. This key is valid only when CategoryName is set to QuotaMaximumDuration.</para>
        /// </description></item>
        /// <item><description><para>predefinedTags: The predefined labels for the workspace. Resources that you create must have these labels.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tempStoragePath</para>
        /// </summary>
        [NameInMap("ConfigKeys")]
        [Validation(Required=false)]
        public string ConfigKeys { get; set; }

        /// <summary>
        /// <para>The labels to use as filter conditions. Separate multiple labels with commas. A logical AND operation is performed on these labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2=value2</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>Specifies whether to return label information.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Returns label information.</para>
        /// </description></item>
        /// <item><description><para>false: Does not return label information.</para>
        /// </description></item>
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
