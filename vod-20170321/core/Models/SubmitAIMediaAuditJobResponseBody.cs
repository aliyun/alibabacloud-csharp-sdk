// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIMediaAuditJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bdbc266af6893943a70176d92e99****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the media file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe028d09441afffb138cd7ee****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F4631053-8D9F-42B2-4A67281DB88E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
