// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveRegistrantProfileRealNameVerificationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4D73432C-7600-****-ACBB-C3B5CA145D32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
