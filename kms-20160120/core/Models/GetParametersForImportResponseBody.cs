// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetParametersForImportResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used to import key material.</para>
        /// <para>The token is valid for 24 hours. The value of this parameter is required when you call the <a href="https://help.aliyun.com/document_detail/68622.html">ImportKeyMaterial</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64String</para>
        /// </summary>
        [NameInMap("ImportToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        /// <summary>
        /// <para>The globally unique ID of the CMK.</para>
        /// <para>The value of this parameter is required when you call the <a href="https://help.aliyun.com/document_detail/68622.html">ImportKeyMaterial</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202b9877-5a25-46e3-a763-e20791b5****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The public key that is used to encrypt key material.</para>
        /// <para>The public key is Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlls4uIBxD0GG84C+lGBO6Dhpf1J3XimC6cPmPNaKKJMOzoX4tD+C+r7aZv8lZ3vnPfxuxvy/YwG+whUxTEEFUdqJTOIzhPfYucupqKM92crVHIuG+xtMVeHKjyTr+UrtKCsQikqHT+19yDRN/RMoo2HUx0gmEnRyXd8t3JyUXun9FdoxKA08GrsV7nodb9ZsoBLhnev7tTLcXvLyKW6XG1ZQCQm6dPnbnwLeDXR7uK0Lqn9PM28mBIdaiQUQxj2XbM1CoJA+JiyVX3Ptdb+4rqukb4Rb05B80Bs9xV/cf7FIku08l7xGhrGiQFq+DFXwQWtwihXHZxz3LhldU+4ZPwID****</para>
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8cdf51fd-bcd6-d79a-0ef4-e52c9b5466dc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the token expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-25T00:01:02Z</para>
        /// </summary>
        [NameInMap("TokenExpireTime")]
        [Validation(Required=false)]
        public string TokenExpireTime { get; set; }

    }

}
