// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetOSSInfoForCardTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>请求状态码。</para>
        /// <list type="bullet">
        /// <item><description>OK：代表请求成功。</description></item>
        /// <item><description>其他错误码，请参见<a href="https://help.aliyun.com/document_detail/101346.html">API错误码</a>。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOSSInfoForCardTemplateResponseBodyData Data { get; set; }
        public class GetOSSInfoForCardTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>签名使用的AccessKey ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI************</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>阿里云账号ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>168**********184</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>OSS文件保存桶名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicom-cardsms-resources</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>超时时间戳。单位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634209418</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>访问地址。</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://***.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>签名策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0wMy0yNlQwMzo0NDoyMy4xNTlaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsMTA0ODU3NjAwMF0sWyJzdGFydHMtd2l0aCIsIiRrZXkiLCIxNDIwNjM0******************</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>短信签名。</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>策略路径。</para>
            /// 
            /// <b>Example:</b>
            /// <para>168**********184</para>
            /// </summary>
            [NameInMap("StartPath")]
            [Validation(Required=false)]
            public string StartPath { get; set; }

        }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>A90E4451-FED7-49D2-87C8-00700A8C4D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>调用接口是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>：调用成功。</para>
        /// </description></item>
        /// <item><description><para><b>false</b>：调用失败。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
