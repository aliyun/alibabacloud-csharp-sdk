// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConfigsRequest : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<UpdateConfigsRequestConfigs> Configs { get; set; }
        public class UpdateConfigsRequestConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CommonResourceConfig</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tempStoragePath</para>
            /// </summary>
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test/s/</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateConfigsRequestConfigsLabels> Labels { get; set; }
            public class UpdateConfigsRequestConfigsLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
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
