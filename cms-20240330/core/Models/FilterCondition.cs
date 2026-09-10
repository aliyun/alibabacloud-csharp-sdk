// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class FilterCondition : TeaModel {
        /// <summary>
        /// <para>The field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>region</para>
        /// </summary>
        [NameInMap("field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EQ</para>
        /// </summary>
        [NameInMap("op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <para>The comparison value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
