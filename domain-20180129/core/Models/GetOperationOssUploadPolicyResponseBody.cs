// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class GetOperationOssUploadPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hObpgEXoca42****</para>
        /// </summary>
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAaMC0wNy0wMlQxKToyMDoxMS44ODRaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsNTI0Mjg4MDBdLFsic3RhcnRzLXdpdGgiLCIka2V5IiwiMTIxOTU0MTE2MTIxMzA1Ny9PRkZMSU5FX1RSQU5TRkVSLzE1OTM2ODg1MTE4ODMi****</para>
        /// </summary>
        [NameInMap("EncodedPolicy")]
        [Validation(Required=false)]
        public string EncodedPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1593688811881</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1219541161213157/OFFLINE_TRANSFER/159368851****</para>
        /// </summary>
        [NameInMap("FileDir")]
        [Validation(Required=false)]
        public string FileDir { get; set; }

        /// <summary>
        /// <para>OSS Endpoint。</para>
        /// 
        /// <b>Example:</b>
        /// <para>//<em><b>-basic-cert.oss-cn-</b></em>.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-40EC-8035-4B12FEFD7D011</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pNVECGkyL0tl4bKXekV5ErZ****</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
