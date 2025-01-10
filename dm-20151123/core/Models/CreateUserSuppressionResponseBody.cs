// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CreateUserSuppressionResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A846D66-5EC7-551B-9687-5BF1963DCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Invalid address number</para>
        /// 
        /// <b>Example:</b>
        /// <para>59511</para>
        /// </summary>
        [NameInMap("SuppressionId")]
        [Validation(Required=false)]
        public string SuppressionId { get; set; }

    }

}
