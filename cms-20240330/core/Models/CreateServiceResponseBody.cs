// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cwzxvuc6uo@d60088ad4797d26</para>
        /// </summary>
        [NameInMap("pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3A2FA9E9-9CF1-5CB1-A808-52828F14310D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cwzxvuc6uo@4bc6b15ad81f166174ffb</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
