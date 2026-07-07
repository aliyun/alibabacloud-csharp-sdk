// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class QueryChildDivisionCodeRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for querying child division codes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public DivisionQuery Body { get; set; }

    }

}
