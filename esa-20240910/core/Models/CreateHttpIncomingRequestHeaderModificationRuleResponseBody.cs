// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpIncomingRequestHeaderModificationRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7C414690-9D7B-5D66-9CD9-AD0B3F25ED49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
