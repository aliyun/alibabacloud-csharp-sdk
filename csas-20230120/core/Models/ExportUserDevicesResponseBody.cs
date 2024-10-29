// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ExportUserDevicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>748CFDC7-1EB6-5B8B-9405-DA76ED5BB60D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://sase-export.oss-cn-hangzhou.aliyuncs.com/export%2Fapp-device%2F20240607154831.xlsx?Expires=1717746571&OSSAccessKeyId=">https://sase-export.oss-cn-hangzhou.aliyuncs.com/export%2Fapp-device%2F20240607154831.xlsx?Expires=1717746571&amp;OSSAccessKeyId=</a>********************</para>
        /// </summary>
        [NameInMap("SignedUrl")]
        [Validation(Required=false)]
        public string SignedUrl { get; set; }

    }

}
