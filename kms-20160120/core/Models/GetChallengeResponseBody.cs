// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetChallengeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJSUzM4NCIsInR5cCI6IkpXVCJ9.eyJub25jZSI6Im1OWnpNVENTc3JVT1JTd1d1WFNneDlTNG80MW1Mc3FPS21xd0d4Tzk******E3NTU5NzIzMDB9.signature-part...=</para>
        /// </summary>
        [NameInMap("ChallengeToken")]
        [Validation(Required=false)]
        public string ChallengeToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mNZzMTCQ******4o1mLsqOKmqwGxO94i9c=</para>
        /// </summary>
        [NameInMap("Nonce")]
        [Validation(Required=false)]
        public string Nonce { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c337a6ee-27d1-465e-acb2-dddef7c3c589</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
