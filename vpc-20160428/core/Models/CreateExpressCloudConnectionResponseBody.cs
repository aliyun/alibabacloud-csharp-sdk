// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressCloudConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ECC instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecc-jg************</para>
        /// </summary>
        [NameInMap("EccId")]
        [Validation(Required=false)]
        public string EccId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C004F022-1CC2-4958-9937-675513A2CD7E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
