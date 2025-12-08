// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetRealPersonVerificationResultRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cwek23dw24geor89230hf2rw</para>
        /// </summary>
        [NameInMap("VerificationToken")]
        [Validation(Required=false)]
        public string VerificationToken { get; set; }

    }

}
