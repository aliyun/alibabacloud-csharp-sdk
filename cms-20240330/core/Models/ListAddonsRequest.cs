// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("regexp")]
        [Validation(Required=false)]
        public bool? Regexp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>105095</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
