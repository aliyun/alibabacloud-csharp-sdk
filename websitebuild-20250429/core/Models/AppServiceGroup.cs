// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppServiceGroup : TeaModel {
        /// <summary>
        /// <para>The name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The QR code.</para>
        /// </summary>
        [NameInMap("QrCode")]
        [Validation(Required=false)]
        public string QrCode { get; set; }

        /// <summary>
        /// <para>The group type, such as dingtalk and wx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
