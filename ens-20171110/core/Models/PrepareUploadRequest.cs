// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PrepareUploadRequest : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The specified IP address. This parameter is applicable to scenarios where the user IP address is inconsistent with the operation calling IP address, such as the scenario where the server obtains authorization and sends the authorization to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.166.XX.XXX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

    }

}
