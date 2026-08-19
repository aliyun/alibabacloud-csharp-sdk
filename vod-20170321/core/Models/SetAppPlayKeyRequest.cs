// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetAppPlayKeyRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000231</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The playback key.</para>
        /// <list type="bullet">
        /// <item><description>Only uppercase letters, lowercase letters, and digits are supported. The length must be 8 to 20 characters.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yzNgTUtAl6HAuosIA</para>
        /// </summary>
        [NameInMap("PlayKey")]
        [Validation(Required=false)]
        public string PlayKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
