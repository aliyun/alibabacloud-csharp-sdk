// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The classification of the configuration item. The following classifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>CommonResourceConfig: The common resource configuration.</para>
        /// </description></item>
        /// <item><description><para>DLCAutoRecycle: The DLC auto-recycle configuration.</para>
        /// </description></item>
        /// <item><description><para>DLCPriorityConfig: The DLC priority settings.</para>
        /// </description></item>
        /// <item><description><para>DSWPriorityConfig: The DSW priority settings.</para>
        /// </description></item>
        /// <item><description><para>QuotaMaximumDuration: The maximum runtime of a DLC task for a quota.</para>
        /// </description></item>
        /// <item><description><para>CommonTagConfig: The tag settings.</para>
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
        /// <item><description><para>isAutoRecycle: The auto-recycle configuration. This key is valid only when CategoryName is set to DLCAutoRecycle.</para>
        /// </description></item>
        /// <item><description><para>priorityConfig: The priority configuration. This key is valid only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</para>
        /// </description></item>
        /// <item><description><para>quotaMaximumDuration: The maximum runtime of a DLC task for a quota. This key is valid only when CategoryName is set to QuotaMaximumDuration.</para>
        /// </description></item>
        /// <item><description><para>predefinedTags: The predefined tags for the workspace. Created resources must have these tags.</para>
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
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The list of labels for the configuration item.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateConfigRequestLabels> Labels { get; set; }
        public class UpdateConfigRequestLabels : TeaModel {
            /// <summary>
            /// <para>The key of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
