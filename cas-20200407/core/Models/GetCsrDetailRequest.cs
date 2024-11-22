// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCsrDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CSR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3924</para>
        /// </summary>
        [NameInMap("CsrId")]
        [Validation(Required=false)]
        public long? CsrId { get; set; }

    }

}
