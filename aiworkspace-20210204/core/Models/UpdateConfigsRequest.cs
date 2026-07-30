// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The list of workspace configurations to update or create.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<UpdateConfigsRequestConfigs> Configs { get; set; }
        public class UpdateConfigsRequestConfigs : TeaModel {
            /// <summary>
            /// <para>The category of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CommonResourceConfig: general resource configuration.</description></item>
            /// <item><description>DLCAutoRecycle: DLC automatic reclamation.</description></item>
            /// <item><description>DLCPriorityConfig: DLC priority settings.</description></item>
            /// <item><description>DSWPriorityConfig: DSW priority settings.</description></item>
            /// <item><description>QuotaMaximumDuration: the maximum running duration of DLC jobs in the quota.</description></item>
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
            /// <para>The key of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>tempStoragePath: the temporary storage path. This ConfigKey is valid only when CategoryName is set to CommonResourceConfig.</description></item>
            /// <item><description>isAutoRecycle: the automatic reclamation configuration. This ConfigKey is valid only when CategoryName is set to DLCAutoRecycle.</description></item>
            /// <item><description>priorityConfig: the priority configuration. This ConfigKey is valid only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
            /// <item><description>quotaMaximumDuration: the maximum running duration of DLC jobs in the quota. This ConfigKey is valid only when CategoryName is set to QuotaMaximumDuration.</description></item>
            /// <item><description>predefinedTags: the preset tags for the workspace. Resources that are created must include these tags.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tempStoragePath</para>
            /// </summary>
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// <para>The configuration value.</para>
            /// <list type="bullet">
            /// <item><description>If ConfigKey is set to predefinedTags, the ConfigValue format is [{&quot;Type&quot;:&quot;Tag&quot;,&quot;Key&quot;:&quot;Key1&quot;,&quot;Value&quot;:&quot;{\&quot;Products\&quot;:\&quot;DLC,DSW,EAS\&quot;,\&quot;Values\&quot;:\&quot;value1,value2,value3\&quot;}&quot;}]. Products specifies which products use the preset tags.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test/s/</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>The list of labels for the configuration item.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateConfigsRequestConfigsLabels> Labels { get; set; }
            public class UpdateConfigsRequestConfigsLabels : TeaModel {
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

}
