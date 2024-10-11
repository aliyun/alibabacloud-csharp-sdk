// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIJobRequest : TeaModel {
        /// <summary>
        /// <para>The list of job IDs. You can obtain the job ID from the PlayInfo parameter in the response to the <a href="https://help.aliyun.com/document_detail/56124.html">GetPlayInfo</a> operation.</para>
        /// <remarks>
        /// <para> You can specify a maximum of 10 job IDs in a request. Separate multiple IDs with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a718a3a1e8bb42ee3bc88921e94****,aasdcsfg782740asd3****,k2l3ibaskod98wrns9d****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

    }

}
