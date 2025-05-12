// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The list of workspace configurations to update or add.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<UpdateConfigsRequestConfigs> Configs { get; set; }
        public class UpdateConfigsRequestConfigs : TeaModel {
            /// <summary>
            /// <para>The category of the configuration item. Supported categories:</para>
            /// <list type="bullet">
            /// <item><description>CommonResourceConfig</description></item>
            /// <item><description>DLCAutoRecycle</description></item>
            /// <item><description>DLCPriorityConfig</description></item>
            /// <item><description>DSWPriorityConfig</description></item>
            /// <item><description>QuotaMaximumDuration</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CommonResourceConfig</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The key of the configuration item. Supported keys:</para>
            /// <list type="bullet">
            /// <item><description>tempStoragePath: Temporary storage path. This key can be used only when CategoryName is set to CommonResourceConfig.</description></item>
            /// <item><description>isAutoRecycle: Automatic recycle configuration. This key can be used only when CategoryName is set to DLCAutoRecycle.</description></item>
            /// <item><description>priorityConfig: Priority configuration. This key can be used only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
            /// <item><description>quotaMaximumDuration Maximum run time of DLC jobs for a quota. This key can be used only when CategoryName is set to QuotaMaximumDuration.</description></item>
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
            /// <para>oss://test/s/</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>The tags of the configuration item.</para>
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
