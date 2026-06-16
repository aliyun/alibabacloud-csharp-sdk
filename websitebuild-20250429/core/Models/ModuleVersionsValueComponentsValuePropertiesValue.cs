// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleVersionsValueComponentsValuePropertiesValue : TeaModel {
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
        public List<ModuleVersionsValueComponentsValuePropertiesValueValues> Values { get; set; }
        public class ModuleVersionsValueComponentsValuePropertiesValueValues : TeaModel {
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

}
