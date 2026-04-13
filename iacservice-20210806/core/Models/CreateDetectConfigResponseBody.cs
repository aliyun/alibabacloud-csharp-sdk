// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateDetectConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dc-xxxx</para>
        /// </summary>
        [NameInMap("detectConfigId")]
        [Validation(Required=false)]
        public string DetectConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
