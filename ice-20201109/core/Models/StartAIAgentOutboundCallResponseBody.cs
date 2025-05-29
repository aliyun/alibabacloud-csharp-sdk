// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartAIAgentOutboundCallResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><em><b><b><b><b>296014bb58670940</b></b></b></b></em></para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><em><b><b><b><b><b>-4417-BDB2</b></b></b></b></b></em>*</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
