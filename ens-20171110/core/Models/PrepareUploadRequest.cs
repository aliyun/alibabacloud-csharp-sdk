// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PrepareUploadRequest : TeaModel {
        /// <summary>
        /// <para>The bucket name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The client\&quot;s IP address. Use this parameter when the client\&quot;s IP address differs from the IP address used to call the API. For example, a server obtains authorization and then sends it to a client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.166.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

    }

}
