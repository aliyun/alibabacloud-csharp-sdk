// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class LabelFilters : TeaModel {
        /// <summary>
        /// <para>The label name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The label filter operator. Supported operators: = (equal to), != (not equal to), =~ (regular expression match), and !~ (regular expression not match).</para>
        /// 
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The label value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
