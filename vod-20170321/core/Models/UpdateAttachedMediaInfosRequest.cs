// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAttachedMediaInfosRequest : TeaModel {
        /// <summary>
        /// The new information about the one or more images. You can modify the information about up to 20 auxiliary media assets at a time. For more information, see the **UpdateContent** section of this topic.
        /// 
        /// > *   You cannot specify emojis for `Title`, `Description`, or `Tags`.
        /// > *   The specific parameter of a video is updated only when a new value is passed in the parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
