// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeModelOssTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>AccessKeyId for uploading files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>Status code. A return value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>OSS domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://safxxxxxxxxx.aliyuncs.com">https://safxxxxxxxxx.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Key required for file upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/xxxxxx/xxxxxx</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Authorization policy for security group control rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A91D2D1-AEC9-1658-ABCE-5A39DE66A5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeModelOssTokenResponseBodyResultObject ResultObject { get; set; }
        public class DescribeModelOssTokenResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>AccessKeyId for uploading files to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>OSS domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://safxxxxxxxxx.aliyuncs.com">https://safxxxxxxxxx.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>Key required for file upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>saf/xxxxxx/xxxxxx</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Authorization policy for security group control rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>OSS signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lUxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>Temporary authorization token for OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>smxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("XOssSecurityToken")]
            [Validation(Required=false)]
            public string XOssSecurityToken { get; set; }

        }

        /// <summary>
        /// <para>OSS signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lUxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Temporary authorization token for OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("XOssSecurityToken")]
        [Validation(Required=false)]
        public string XOssSecurityToken { get; set; }

    }

}
