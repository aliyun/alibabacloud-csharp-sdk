// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the secret is scheduled to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-15T07:02:14Z</para>
        /// </summary>
        [NameInMap("PlannedDeleteTime")]
        [Validation(Required=false)]
        public string PlannedDeleteTime { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38bbed2a-15e0-45ad-98d4-816ad2ccf4ea</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
