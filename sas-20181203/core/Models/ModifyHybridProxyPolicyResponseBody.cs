// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyHybridProxyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The message of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterName data not exist</para>
        /// </summary>
        [NameInMap("Messgae")]
        [Validation(Required=false)]
        public string Messgae { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
