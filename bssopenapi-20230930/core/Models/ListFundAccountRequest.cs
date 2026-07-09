// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListFundAccountRequest : TeaModel {
        /// <summary>
        /// <para>Level-1 marketplace ID. If this parameter is left empty, the ID of the marketplace to which the current user belongs is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the active account list. Default value: false.</para>
        /// </summary>
        [NameInMap("QueryOnlyInUse")]
        [Validation(Required=false)]
        public bool? QueryOnlyInUse { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the managed account list. Default value: false.</para>
        /// </summary>
        [NameInMap("QueryOnlyManage")]
        [Validation(Required=false)]
        public bool? QueryOnlyManage { get; set; }

    }

}
