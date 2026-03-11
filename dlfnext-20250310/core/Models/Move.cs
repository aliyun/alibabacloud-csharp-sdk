// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Move : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>other_col_test</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>col_test</para>
        /// </summary>
        [NameInMap("referenceFieldName")]
        [Validation(Required=false)]
        public string ReferenceFieldName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FIRST</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
