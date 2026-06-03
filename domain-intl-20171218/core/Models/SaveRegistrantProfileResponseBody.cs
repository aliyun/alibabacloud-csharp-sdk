// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class SaveRegistrantProfileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12380891</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A9C35C47-3366-482E-B872-8C9EA4733FE9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
