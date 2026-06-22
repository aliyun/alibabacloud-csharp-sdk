// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizedDictUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID required to access the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeyID</para>
        /// </summary>
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        /// <summary>
        /// <para>The expiration time of the authentication, in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719921470</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// <para>The OSS domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aegis-update-static-file.oss-cn-hangzhou.aliyuncs.com">https://aegis-update-static-file.oss-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The OSS file key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HC_CUSTOMIZED_DICT/176618589410****.tmp</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The bucket policy of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAyNC0wNy0wMlQxMTo1Nzo1MC44MzJaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsNDA5NjBdLFsiZXEiLCIka2V5IiwiSENfQ1VTVE9NSVpFRF9ESUNUXC8xNzY2MTg1ODk0MTA0Njc1LnRtc****</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this identifier to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDEDEEE7-AC25-559E-8C12-5168B139****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Security Token Service (STS) token.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The OSS signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mWGRgn0CtdbVf8UuJbTXOmo2****</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
