// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListFundAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        [NameInMap("QueryOnlyInUse")]
        [Validation(Required=false)]
        public bool? QueryOnlyInUse { get; set; }

        [NameInMap("QueryOnlyManage")]
        [Validation(Required=false)]
        public bool? QueryOnlyManage { get; set; }

    }

}
