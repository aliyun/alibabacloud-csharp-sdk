// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForGenerateDomainCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40F46D3D-F4F3-4CCB-AC30-2DD20E32E528</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8b1cd755-4928-4b02-adee-e5d41d7b1939</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
