// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetCallDetailRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c28fc549-d88f-4f6e-85ad-a0806e5e39c0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9fe19f64-a290-4a73-a3ed-5f7d21d44ecb</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
