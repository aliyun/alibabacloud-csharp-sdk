// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations list.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListUserConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The category. Currently, only DataPrivacyConfig is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataPrivacyConfig</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The key of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customizePAIAssumedRole</para>
            /// </summary>
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>The scope. Currently, subUser and owner are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subUser</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdjksdk-******-dsfds</para>
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
