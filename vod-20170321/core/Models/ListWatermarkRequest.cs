// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListWatermarkRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**.
        /// 
        /// If you have activated the multi-application service, specify the ID of the application to query all image and text watermark templates in the specified application. If you leave this parameter empty, image and text watermark templates in all applications are queried. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
