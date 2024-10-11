// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitMediaDNADeleteJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6805B2EC-CE87-****-8FF6-9C0E97719A26</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e5b1a2e7bee******b632c2710b9423f</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
