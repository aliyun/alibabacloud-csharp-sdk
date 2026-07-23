// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetManagedDataKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the managed data key (DK).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-data-key</para>
        /// </summary>
        [NameInMap("DataKeyName")]
        [Validation(Required=false)]
        public string DataKeyName { get; set; }

        /// <summary>
        /// <para>The version number of the returned managed data key (DK).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xH6OPUmz</para>
        /// </summary>
        [NameInMap("DataKeyVersionId")]
        [Validation(Required=false)]
        public string DataKeyVersionId { get; set; }

        /// <summary>
        /// <para>The credential name that stores the key material of the returned managed data key (DK) version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kms-datakeyversion!example-data-key!xH6OPUmz</para>
        /// </summary>
        [NameInMap("DataKeyVersionName")]
        [Validation(Required=false)]
        public string DataKeyVersionName { get; set; }

        /// <summary>
        /// <para>The Base64-encoding plaintext value of the data key (DK).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CYueyVmZJ2MfA1VSZV2jCbFT8bO7StAvBnHacplr9aI=</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4bd560a1-729e-45f1-a3d9-b2a33d61046b</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
