// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class AddApplicationAccountToUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aac_m6z7awz5kresi2ezgajsbkxxxx</para>
        /// </summary>
        [NameInMap("ApplicationAccountId")]
        [Validation(Required=false)]
        public string ApplicationAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
