// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleNextComponentsValue : TeaModel {
        /// <summary>
        /// <para>The unique component code (internal system identifier).</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The display name of the component (user-visible name).</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The instance property configuration of the component.</para>
        /// </summary>
        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleNextComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleNextComponentsValueInstanceProperty : TeaModel {
            /// <summary>
            /// <para>The property code (internal system identifier).</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The display name of the property (user-visible name).</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The property value code (internal system value).</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The list of module property values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ModuleNextComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleNextComponentsValueInstancePropertyValues : TeaModel {
                /// <summary>
                /// <para>The property code (internal system identifier).</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeholder</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property value code (internal system value).</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeholder</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The display name of the property (user-visible name).</para>
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
        /// <para>The instance property configuration of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;deploy_area&quot;:{&quot;Code&quot;:&quot;deploy_area&quot;,&quot;Name&quot;:&quot;Deployment region&quot;,&quot;Value&quot;:&quot;HongKong&quot;,&quot;Values&quot;:[{&quot;Value&quot;:&quot;HongKong&quot;,&quot;Name&quot;:&quot;China (Hong Kong)&quot;}]}}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleNextComponentsValuePropertiesValue> Properties { get; set; }

        /// <summary>
        /// <para>The module property status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModuleAttrStatus")]
        [Validation(Required=false)]
        public int? ModuleAttrStatus { get; set; }

    }

}
