// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TagCondition : TeaModel {
        /// <summary>
        /// <para>The tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

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
        /// <para>The tag value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
