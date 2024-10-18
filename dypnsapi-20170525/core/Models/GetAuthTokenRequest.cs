// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetAuthTokenRequest : TeaModel {
        /// <summary>
        /// <para>The requested domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyundoc.com">https://www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The URL of the requested web page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyundoc.com/">https://www.aliyundoc.com/</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
