// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20250301.Models
{
    public class CreateOssUploadTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LTAI5tQPEXqDVu7794Bvw2xM</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1740758400000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket-name.oss-zhangjiakou.aliyuncs.com">https://bucket-name.oss-zhangjiakou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>path/filename.jsonl</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vyAnsgE0fgjYGF0W79ryhhhQmec=</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABCDEFGH-1234-5678-90AB-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vyAnsgE0fgjYGF0W79ryhhhQmec=</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket-name.oss-zhangjiakou.aliyuncs.com/path/filename.jsonl">https://bucket-name.oss-zhangjiakou.aliyuncs.com/path/filename.jsonl</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
