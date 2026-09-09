// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetMaterializedViewRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the materialized view status information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("returnStatus")]
        [Validation(Required=false)]
        public bool? ReturnStatus { get; set; }

    }

}
