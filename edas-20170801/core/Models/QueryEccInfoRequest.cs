// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryEccInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ECC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("EccId")]
        [Validation(Required=false)]
        public string EccId { get; set; }

    }

}
