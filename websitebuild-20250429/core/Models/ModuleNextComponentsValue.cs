// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleNextComponentsValue : TeaModel {
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
        /// <para>Widget display name (User-visible name)</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Widget instance property configuration</para>
        /// </summary>
        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleNextComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleNextComponentsValueInstanceProperty : TeaModel {
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
            /// <para>Attribute Value encoding (internal System value)</para>
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
            public List<ModuleNextComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleNextComponentsValueInstancePropertyValues : TeaModel {
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
                /// <para>Attribute Value encoding (internal System value)</para>
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
        /// <para>widget instance attribute configuration</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleNextComponentsValuePropertiesValue> Properties { get; set; }

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
