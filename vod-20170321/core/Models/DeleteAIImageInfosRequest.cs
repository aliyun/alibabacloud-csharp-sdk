// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAIImageInfosRequest : TeaModel {
        /// <summary>
        /// The IDs of the images that are submitted for AI processing. You can obtain the value of AIImageInfoId from the response to the [ListAIImageInfo](~~ListAIImageInfo~~) operation.
        /// 
        /// - You can specify a maximum of 10 IDs.
        /// - Separate multiple IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AIImageInfoIds")]
        [Validation(Required=false)]
        public string AIImageInfoIds { get; set; }

    }

}
