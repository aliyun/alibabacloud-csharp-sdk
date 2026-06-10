// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleDataComponentsValue : TeaModel {
        /// <summary>
        /// <para>Unique widget encoding (system internal identity)</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The display name of the widget (user-visible name)</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Widget instance attribute configuration</para>
        /// </summary>
        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleDataComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleDataComponentsValueInstanceProperty : TeaModel {
            /// <summary>
            /// <para>Property encoding (system internal identity)</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Property display name (User-visible Name)</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Attribute Value encoding (internal system value)</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>List of module Attribute Values</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ModuleDataComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleDataComponentsValueInstancePropertyValues : TeaModel {
                /// <summary>
                /// <para>Property encoding (system internal identity)</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeholder</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Attribute Value encoding (internal system value)</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeholder</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>Property display name (User-visible Name)</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeholder</para>
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
        public Dictionary<string, ModuleDataComponentsValuePropertiesValue> Properties { get; set; }

        /// <summary>
        /// <para>Module attribute status</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("ModuleAttrStatus")]
        [Validation(Required=false)]
        public int? ModuleAttrStatus { get; set; }

    }

}
