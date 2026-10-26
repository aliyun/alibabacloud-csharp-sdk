// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The locale. Valid values: zh and en. Default value: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The tag filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to use regular expression matching for the query field. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("regexp")]
        [Validation(Required=false)]
        public bool? Regexp { get; set; }

        /// <summary>
        /// <para>The search query. Supports searching by add-on name, description, or keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105095</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
