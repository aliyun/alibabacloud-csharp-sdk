// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class CreateEaisEiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-hzu00xufs1c8j5nn****</para>
        /// </summary>
        [NameInMap("EiInstanceId")]
        [Validation(Required=false)]
        public string EiInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F5FEB9AA-C108-577C-AB3D-D13524AF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
