// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleVersionsValueComponentsValue : TeaModel {
        /// <summary>
        /// <para>The unique code of the component, which is an internal system identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComponentCode</para>
        /// </summary>
        [NameInMap("ComponentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        /// <summary>
        /// <para>The display name of the component, which is visible to users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComponentName</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The instance property configuration of the component.</para>
        /// </summary>
        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleVersionsValueComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleVersionsValueComponentsValueInstanceProperty : TeaModel {
            /// <summary>
            /// <para>The code of the property, which is an internal system identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The display name of the property, which is visible to users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The code of the property value, which is an internal system value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The list of module property values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ModuleVersionsValueComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleVersionsValueComponentsValueInstancePropertyValues : TeaModel {
                /// <summary>
                /// <para>The code of the property, which is an internal system identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The code of the property value, which is an internal system value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The display name of the property, which is visible to users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance property configuration of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleVersionsValueComponentsValuePropertiesValue> Properties { get; set; }

        /// <summary>
        /// <para>The status of the module property.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModuleAttrStatus")]
        [Validation(Required=false)]
        public int? ModuleAttrStatus { get; set; }

    }

}
