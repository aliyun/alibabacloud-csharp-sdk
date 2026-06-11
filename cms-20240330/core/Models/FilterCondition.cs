// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class FilterCondition : TeaModel {
        /// <summary>
        /// <para>The name of the field to filter on.</para>
        /// </summary>
        [NameInMap("field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The comparison operator, such as <c>equals</c> or <c>startsWith</c>.</para>
        /// </summary>
        [NameInMap("op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <para>The value to match for the specified field and operator.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
