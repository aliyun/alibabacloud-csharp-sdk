// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configuration items.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID, which is globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wc-95******o36ylr</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>The key of the configuration item. The following keys are supported:</para>
            /// <list type="bullet">
            /// <item><description>tempStoragePath: the temporary storage path. This ConfigKey can be used only when CategoryName is set to CommonResourceConfig.</description></item>
            /// <item><description>isAutoRecycle: the automatic recycling configuration. This ConfigKey can be used only when CategoryName is set to DLCAutoRecycle.</description></item>
            /// <item><description>priorityConfig: the priority configuration. This ConfigKey can be used only when CategoryName is set to DLCPriorityConfig or DSWPriorityConfig.</description></item>
            /// <item><description>quotaMaximumDuration: the maximum runtime duration configuration for DLC jobs in a quota. This ConfigKey can be used only when CategoryName is set to QuotaMaximumDuration.</description></item>
            /// <item><description>predefinedTags: the preset tags for the workspace. Resources that are created must include these tags.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tempTableLifecycle</para>
            /// </summary>
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// <para>The configuration value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://***</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>The UTC time when the configuration item was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-12T07:59:41.000Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The UTC time when the configuration item was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:44:10.000Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The list of labels for the configuration item.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListConfigsResponseBodyConfigsLabels> Labels { get; set; }
            public class ListConfigsResponseBodyConfigsLabels : TeaModel {
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A******C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
