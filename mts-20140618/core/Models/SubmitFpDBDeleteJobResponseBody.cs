// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitFpDBDeleteJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the job. We recommend that you keep this ID for subsequent operation calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d98459323c024947a104f6a50cbf****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4247B23C-26DE-529F-8D9F-FD6811AE979B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
