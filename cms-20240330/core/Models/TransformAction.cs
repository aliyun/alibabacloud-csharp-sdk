// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformAction : TeaModel {
        /// <summary>
        /// <para>筛选配置</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>标签名</para>
        /// 
        /// <b>Example:</b>
        /// <para>labelkey1</para>
        /// </summary>
        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// <para>Mapping配置。</para>
        /// </summary>
        [NameInMap("mapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> Mapping { get; set; }

        /// <summary>
        /// <para>正则表达式</para>
        /// 
        /// <b>Example:</b>
        /// <para>(.<em>):(.</em>)</para>
        /// </summary>
        [NameInMap("regExp")]
        [Validation(Required=false)]
        public string RegExp { get; set; }

        /// <summary>
        /// <para>引用路径</para>
        /// 
        /// <b>Example:</b>
        /// <para>data.subject</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>目标位置</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUBJECT</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>转换类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>SET_FIELD</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>设置的值</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>变量名</para>
        /// 
        /// <b>Example:</b>
        /// <para>var1</para>
        /// </summary>
        [NameInMap("variable")]
        [Validation(Required=false)]
        public string Variable { get; set; }

    }

}
