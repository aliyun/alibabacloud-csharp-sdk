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
            /// <para>tempTableLifecycle</para>
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

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A******C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
