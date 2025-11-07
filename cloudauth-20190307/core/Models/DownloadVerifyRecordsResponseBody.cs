// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DownloadVerifyRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6163397-15C5-419C-9ACC-B7C83E0B4C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>OSS link for file download.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth.oss-cn-shanghai.aliyuncs.com/invoke_download/0E30CD55-DCD4-5363-AA98-XXXXXXX">https://cn-shanghai-aliyun-cloudauth.oss-cn-shanghai.aliyuncs.com/invoke_download/0E30CD55-DCD4-5363-AA98-XXXXXXX</a></para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public string ResultObject { get; set; }

    }

}
