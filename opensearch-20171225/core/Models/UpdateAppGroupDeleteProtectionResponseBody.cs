// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateAppGroupDeleteProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>80326EFE-485F-46E7-B291-5A1DD08D2198</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateAppGroupDeleteProtectionResponseBodyResult Result { get; set; }
        public class UpdateAppGroupDeleteProtectionResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ops-cn-m7r1ywo2h1b</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
