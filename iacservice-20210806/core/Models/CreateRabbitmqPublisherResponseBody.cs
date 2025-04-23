// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateRabbitmqPublisherResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mqp-3b6cb9fa4751afffb0af06b9ba504</para>
        /// </summary>
        [NameInMap("publisherId")]
        [Validation(Required=false)]
        public string PublisherId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C3DA172D-DDCF-5268-BB0F-060C3A9D2623</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
