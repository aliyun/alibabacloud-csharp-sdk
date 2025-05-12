// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration items.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The key of the configuration item. Supported keys:</para>
            /// <list type="bullet">
            /// <item><description>tempStoragePath: Temporary storage path. This key can be used only when CategoryName is set to CommonResourceConfig.</description></item>
            /// <item><description>isAutoRecycle: Automatic recycle configuration. This key can be used only when CategoryName is set to DLCAutoRecycle.</description></item>
            /// <item><description>tempStoragePath: Temporary storage path. This key can be used only when CategoryName is set to CommonResourceConfig.</description></item>
            /// <item><description>quotaMaximumDuration Maximum run time of DLC jobs for a quota. This key can be used only when CategoryName is set to QuotaMaximumDuration.</description></item>
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

            /// <summary>
            /// <para>The tags of the configuration item.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListConfigsResponseBodyConfigsLabels> Labels { get; set; }
            public class ListConfigsResponseBodyConfigsLabels : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
        /// <para>The number of items returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
