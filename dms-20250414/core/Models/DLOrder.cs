// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLOrder : TeaModel {
        /// <summary>
        /// <para>The name of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col1</para>
        /// </summary>
        [NameInMap("Col")]
        [Validation(Required=false)]
        public string Col { get; set; }

        /// <summary>
        /// <para>The position of the column in the sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public int? Order { get; set; }

    }

}
