// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CheckBudgetNameExistsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>department1</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exists")]
        [Validation(Required=false)]
        public bool? Exists { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F1E2D3C4-B5A6-7890-1234-567890ABCDEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
