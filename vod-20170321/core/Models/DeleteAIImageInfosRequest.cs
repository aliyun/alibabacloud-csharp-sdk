// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAIImageInfosRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the images that are submitted for AI processing. You can obtain the value of AIImageInfoId from the response to the <a href="~~ListAIImageInfo~~">ListAIImageInfo</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 10 IDs.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b89a6aabf144*****6197ebd6fe6cf29</para>
        /// </summary>
        [NameInMap("AIImageInfoIds")]
        [Validation(Required=false)]
        public string AIImageInfoIds { get; set; }

    }

}
