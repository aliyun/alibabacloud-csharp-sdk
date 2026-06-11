// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformAction : TeaModel {
        /// <summary>
        /// <para>The filter configuration.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>The label name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>labelkey1</para>
        /// </summary>
        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// <para>The mapping configuration.</para>
        /// </summary>
        [NameInMap("mapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> Mapping { get; set; }

        /// <summary>
        /// <para>The regular expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(.<em>):(.</em>)</para>
        /// </summary>
        [NameInMap("regExp")]
        [Validation(Required=false)]
        public string RegExp { get; set; }

        /// <summary>
        /// <para>The reference path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data.subject</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The target location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUBJECT</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The transform type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SET_FIELD</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value to set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The variable name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>var1</para>
        /// </summary>
        [NameInMap("variable")]
        [Validation(Required=false)]
        public string Variable { get; set; }

    }

}
