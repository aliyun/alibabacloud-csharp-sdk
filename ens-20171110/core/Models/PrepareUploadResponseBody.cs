// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PrepareUploadResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the bucket. This parameter is available only when the OSS SDK is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-xxxxxx</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The endpoint. This parameter is available only when the OSS SDK is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eos.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6666C5A5-75ED-422E-A022-7121FA18C968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
