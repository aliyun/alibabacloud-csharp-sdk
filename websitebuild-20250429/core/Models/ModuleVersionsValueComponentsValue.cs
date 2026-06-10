// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleVersionsValueComponentsValue : TeaModel {
        /// <summary>
        /// <para>Unique component code (system internal identity)</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComponentCode</para>
        /// </summary>
        [NameInMap("ComponentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        /// <summary>
        /// <para>Widget display name (user-visible name)</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComponentName</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>Component instance attribute configuration</para>
        /// </summary>
        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleVersionsValueComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleVersionsValueComponentsValueInstanceProperty : TeaModel {
            /// <summary>
            /// <para>Property encoding (system internal identity)</para>
            /// 
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Attribute display name (user-visible name)</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Attribute Value encoding (internal System value)</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>List of module Attribute Values</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ModuleVersionsValueComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleVersionsValueComponentsValueInstancePropertyValues : TeaModel {
                /// <summary>
                /// <para>Property encoding (system internal identity)</para>
                /// 
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Attribute Value encoding (internal System value)</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>Property display name (User-visible name)</para>
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
        /// <para>Widget instance attribute configuration</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleVersionsValueComponentsValuePropertiesValue> Properties { get; set; }

        /// <summary>
        /// <para>Module property status</para>
        /// 
        /// <b>Example:</b>
        /// <para>attr</para>
        /// </summary>
        [NameInMap("ModuleAttrStatus")]
        [Validation(Required=false)]
        public int? ModuleAttrStatus { get; set; }

    }

}
