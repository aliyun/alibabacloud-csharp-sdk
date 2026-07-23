// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListEngineConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of engine configurations.</para>
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
            /// <para>The description of the engine configuration.</para>
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
            /// <para>The environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Daily</b>: the development and test environment.</para>
            /// </description></item>
            /// <item><description><para><b>Pre</b>: the pre-production environment.</para>
            /// </description></item>
            /// <item><description><para><b>Prod</b>: the production environment.</para>
            /// </description></item>
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
            /// <para>The modification time.</para>
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
            /// <para>The status of the engine configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Released</b>: The configuration has been released.</para>
            /// </description></item>
            /// <item><description><para><b>Unreleased</b>: The configuration has not been released.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Released</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version of the currently released or most recently updated engine configuration.</para>
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
