// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageAuditJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the image review job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1aa3024aee64*****6dc8ca20dbc328</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F42D500-1956-4B*****30-C09E755F4F4B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
