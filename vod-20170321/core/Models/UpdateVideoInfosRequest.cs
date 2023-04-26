// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfosRequest : TeaModel {
        /// <summary>
        /// ## UpdateContent
        /// 
        /// >  You must convert the UpdateContent[] parameter to a string before you pass it in.
        /// 
        /// | Parameter | Type | Required | Description |
        /// | --------- | ---- | -------- | ----------- |
        /// | VideoId | String | Yes | The ID of the video. |
        /// | Title | String | No | The title of the video. |
        /// | Description | String | No | The description of the video. |
        /// | Tags | String | No | The tag of the video. |
        /// | CoverURL | String | No | The URL of the video thumbnail. |
        /// | CateId | Long | No | The ID of the category. |
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
