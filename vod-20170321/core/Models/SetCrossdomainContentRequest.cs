// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetCrossdomainContentRequest : TeaModel {
        /// <summary>
        /// <para>The content of the cross-domain policy file. The file must be in the XML format and can contain up to 2,048 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&lt;cross-domain-policy&gt;&lt;allow-access-from domain=&quot;<em>&quot;/&gt;&lt;allow-http-request-headers-from domain=&quot;</em>&quot; headers=&quot;*&quot; secure=&quot;false&quot;/&gt;&lt;/cross-domain-policy&gt;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3461111</para>
        /// </summary>
        [NameInMap("ResourceRealOwnerId")]
        [Validation(Required=false)]
        public string ResourceRealOwnerId { get; set; }

        /// <summary>
        /// <para>The URL of the Object Storage Service (OSS) bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outin-67870fd5b****1e98a3900163e1c35d5.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
