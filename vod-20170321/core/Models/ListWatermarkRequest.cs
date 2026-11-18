// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>.</para>
        /// <para>If the multi-application system is enabled, you can specify an application ID to query the image and text watermark templates of a specific application. If you do not specify this parameter, the system returns the image and text watermark templates of all applications by default. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
