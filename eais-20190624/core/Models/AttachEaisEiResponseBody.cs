// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class AttachEaisEiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp14ws9hbt1oe0u9****</para>
        /// </summary>
        [NameInMap("ClientInstanceId")]
        [Validation(Required=false)]
        public string ClientInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-hzu00xufs1c8j5nn****</para>
        /// </summary>
        [NameInMap("EiInstanceId")]
        [Validation(Required=false)]
        public string EiInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C3BCB7DA-BEB6-4982-A765-6EA61EC8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
