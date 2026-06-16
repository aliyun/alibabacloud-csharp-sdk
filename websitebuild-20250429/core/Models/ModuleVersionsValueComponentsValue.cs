// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleVersionsValueComponentsValue : TeaModel {
        /// <summary>
        /// <para>组件唯一编码（系统内部标识）</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComponentCode</para>
        /// </summary>
        [NameInMap("ComponentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        /// <summary>
        /// <para>组件显示名称（用户可见名称）</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComponentName</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>组件实例属性配置</para>
        /// </summary>
        [NameInMap("InstanceProperty")]
        [Validation(Required=false)]
        public List<ModuleVersionsValueComponentsValueInstanceProperty> InstanceProperty { get; set; }
        public class ModuleVersionsValueComponentsValueInstanceProperty : TeaModel {
            /// <summary>
            /// <para>属性编码（系统内部标识）</para>
            /// 
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>属性显示名称（用户可见名称）</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>属性值编码（系统内部值）</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>模块属性值列表</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ModuleVersionsValueComponentsValueInstancePropertyValues> Values { get; set; }
            public class ModuleVersionsValueComponentsValueInstancePropertyValues : TeaModel {
                /// <summary>
                /// <para>属性编码（系统内部标识）</para>
                /// 
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>属性值编码（系统内部值）</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>属性显示名称（用户可见名称）</para>
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
        /// <para>组件实例属性配置</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleVersionsValueComponentsValuePropertiesValue> Properties { get; set; }

        /// <summary>
        /// <para>模块属性状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>attr</para>
        /// </summary>
        [NameInMap("ModuleAttrStatus")]
        [Validation(Required=false)]
        public int? ModuleAttrStatus { get; set; }

    }

}
