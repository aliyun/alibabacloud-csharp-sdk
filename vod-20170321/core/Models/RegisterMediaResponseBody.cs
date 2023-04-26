// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaResponseBody : TeaModel {
        /// <summary>
        /// ## RegisterMetadata
        /// 
        /// The following table describes the metadata of the media file that you want to register. 
        /// 
        /// | Parameter | Type | Required | Description |
        /// | --------- | ---- | -------- | ----------- |
        /// | FileURL | String | Yes | The OSS URL of the source file. You can call the [GetMezzanineInfo](~~GetMezzanineInfo~~) operation to obtain the OSS URL of the source file.  <br>The URL can be up to 1,024 bytes in length. The file name must be globally unique. If the media file that you want to register is registered before, the unique media ID that is associated with the media file is returned. |
        /// | Title | String | Yes | The title of the media file. The title can be up to 128 bytes in length. The value must be encoded in UTF-8. |
        /// | Description | String | No | The description of the media file. The description can be up to 1,024 bytes in length. The value must be encoded in UTF-8. |
        /// | Tags | String | No | The one or more tags of the media file. Each tag can be up to 32 bytes in length. You can specify a maximum of 16 tags. Separate multiple tags with commas (,). The value must be encoded in UTF-8. |
        /// | CoverURL | String | No | The URL of the thumbnail. The URL can be up to 1,024 bytes in length. |
        /// | CateId | Long | No | The category ID of the media file. You can use one of the following methods to obtain the category ID: <br>Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com/). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories**. On the Categories page, you can view the category ID of the media file.  <br>View the value of the CateId parameter returned by the [AddCategory](~~AddCategory~~) operation that you called to create a category.  <br>View the value of the CateId parameter returned by the [GetCategories](~~GetCategories~~) operation that you called to query a category. |
        /// </summary>
        [NameInMap("FailedFileURLs")]
        [Validation(Required=false)]
        public List<string> FailedFileURLs { get; set; }

        [NameInMap("RegisteredMediaList")]
        [Validation(Required=false)]
        public List<RegisterMediaResponseBodyRegisteredMediaList> RegisteredMediaList { get; set; }
        public class RegisterMediaResponseBodyRegisteredMediaList : TeaModel {
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("NewRegister")]
            [Validation(Required=false)]
            public bool? NewRegister { get; set; }

        }

        /// <summary>
        /// The OSS URL of the media file.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
