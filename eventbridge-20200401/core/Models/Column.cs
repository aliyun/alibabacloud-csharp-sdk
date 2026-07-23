// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Column : TeaModel {
        /// <summary>
        /// <para>Whether the value is NULL. When true, it should be treated as NULL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsNull")]
        [Validation(Required=false)]
        public bool? IsNull { get; set; }

        /// <summary>
        /// <para>Column name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Column type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Column value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product_info</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
