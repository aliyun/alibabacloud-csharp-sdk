// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the image AI processing job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf08a2c6e11e*****de1711b738b9067</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>218A6807-A21E-43*****54-C0512880B0B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
