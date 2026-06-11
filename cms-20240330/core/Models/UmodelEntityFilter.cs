// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UmodelEntityFilter : TeaModel {
        /// <summary>
        /// <para>The field name to filter on.</para>
        /// </summary>
        [NameInMap("field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The comparison operator to use. Supported operators include <c>=</c>, <c>&gt;</c>, <c>&lt;</c>, <c>!=</c>, <c>IN</c>, and <c>NOT IN</c>.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The value to compare the field against.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
