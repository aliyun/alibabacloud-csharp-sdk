// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleVersionsValueComponentsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ComponentCode</para>
        /// </summary>
        [NameInMap("ComponentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ComponentName</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleVersionsValueComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleVersionsValueComponentsValueInstanceProperty : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ModuleVersionsValueComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleVersionsValueComponentsValueInstancePropertyValues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleVersionsValueComponentsValuePropertiesValue> Properties { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>attr</para>
        /// </summary>
        [NameInMap("ModuleAttrStatus")]
        [Validation(Required=false)]
        public int? ModuleAttrStatus { get; set; }

    }

}
