// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListEngineConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The engine configurations.</para>
        /// </summary>
        [NameInMap("EngineConfigs")]
        [Validation(Required=false)]
        public List<ListEngineConfigsResponseBodyEngineConfigs> EngineConfigs { get; set; }
        public class ListEngineConfigsResponseBodyEngineConfigs : TeaModel {
            /// <summary>
            /// <para>The content of the engine configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>what</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the engine configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EngineConfigId")]
            [Validation(Required=false)]
            public string EngineConfigId { get; set; }

            /// <summary>
            /// <para>The runtime environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily: Daily environment.</description></item>
            /// <item><description>Pre: Staging environment.</description></item>
            /// <item><description>Prod: Production environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pre</para>
            /// </summary>
            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-07T01:43:42Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-27T12:00:00Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The release time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-29 12:00:00</para>
            /// </summary>
            [NameInMap("GmtReleasedTime")]
            [Validation(Required=false)]
            public string GmtReleasedTime { get; set; }

            /// <summary>
            /// <para>The name of the engine configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine_config_v1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Released: Released.</description></item>
            /// <item><description>UnReleased: Unreleased.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Released</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the engine configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number of the currently released or most recently updated version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230509161300</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74D958EF-3598-56FA-8296-FF1575CE43DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
