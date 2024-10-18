// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GrantHonorResponseBody : TeaModel {
        [NameInMap("failedUserIds")]
        [Validation(Required=false)]
        public List<string> FailedUserIds { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>45b4d029-ab94-4672-aa0f-bd79590374cb</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("successUserIds")]
        [Validation(Required=false)]
        public List<string> SuccessUserIds { get; set; }

    }

}
