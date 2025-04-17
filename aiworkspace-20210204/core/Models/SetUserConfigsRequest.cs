// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class SetUserConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The configurations list.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<SetUserConfigsRequestConfigs> Configs { get; set; }
        public class SetUserConfigsRequestConfigs : TeaModel {
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
            /// <para>owner</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

    }

}
