// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIImageJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image AI processing job. You can obtain the value of JobId from the response to the <a href="~~SubmitAIImageJob~~">SubmitAIImageJob</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 10 IDs.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf08a2c6e11e*****de1711b738b9067</para>
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
