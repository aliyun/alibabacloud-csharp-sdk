// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConfigsRequest : TeaModel {
        /// <summary>
        /// <para>A list of workspace configurations to update or add.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<UpdateConfigsRequestConfigs> Configs { get; set; }
        public class UpdateConfigsRequestConfigs : TeaModel {
            /// <summary>
            /// <para>The category of the configuration item. The following categories are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>CommonResourceConfig: General resource configuration.</para>
            /// </description></item>
            /// <item><description><para>DLCAutoRecycle: DLC automatic recycling.</para>
            /// </description></item>
            /// <item><description><para>DLCPriorityConfig: DLC priority settings.</para>
            /// </description></item>
            /// <item><description><para>DSWPriorityConfig: DSW priority settings.</para>
            /// </description></item>
            /// <item><description><para>QuotaMaximumDuration: Configuration for the maximum runtime of a DLC job within a quota.</para>
            /// </description></item>
            /// <item><description><para>CommonTagConfig: Tag settings.</para>
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
            /// <item><description><para>isAutoRecycle: The configuration for automatic resource recycling. This key is valid only when CategoryName is set to DLCAutoRecycle.</para>
            /// </description></item>
            /// <item><description><para>priorityConfig: The priority configuration. This key is valid only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</para>
            /// </description></item>
            /// <item><description><para>quotaMaximumDuration: The maximum runtime configuration for a DLC job within a quota. This key is valid only when CategoryName is set to QuotaMaximumDuration.</para>
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
            /// <list type="bullet">
            /// <item><description>If ConfigKey is set to predefinedTags, the format of ConfigValue is [{&quot;Type&quot;:&quot;Tag&quot;,&quot;Key&quot;:&quot;Key1&quot;,&quot;Value&quot;:&quot;{\\&quot;Products\\&quot;:\\&quot;DLC,DSW,EAS\\&quot;,\\&quot;Values\\&quot;:\\&quot;value1,value2,value3\\&quot;}&quot;}]. The Products field specifies which products use the predefined tags.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test/s/</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>A list of tags for the configuration item.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateConfigsRequestConfigsLabels> Labels { get; set; }
            public class UpdateConfigsRequestConfigsLabels : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
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

}
