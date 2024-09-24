// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDynamicDictUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID that is used to access OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI4G1mgPbjvG********</para>
        /// </summary>
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        /// <summary>
        /// <para>The validity period of the signature. The value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719919893</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// <para>The OSS endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aegis-update-static-file.oss-cn-hangzhou.aliyuncs.com">https://aegis-update-static-file.oss-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The name of the OSS object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DegradePool_Offset_****</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The OSS security policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAyNC0wNy0wMlQxMTozMTozMy40MjlaIiwiY29uZGl0aW9********</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The signature that is calculated based on <b>AccessKeySecret</b> and <b>Policy</b>. When you call an OSS API operation, OSS uses the signature information to check the validity of the POST request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wBiwkhd5LGcLzijtc3FhI****</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
