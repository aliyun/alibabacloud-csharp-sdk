// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsOcrOssInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>访问被拒绝详细信息，只有 RAM 校验失败才会返回此字段。</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>请求状态码。</para>
        /// <list type="bullet">
        /// <item><description><para>返回 OK 代表请求成功。</para>
        /// </description></item>
        /// <item><description><para>其他错误码，请参见 <a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-error-codes">API 错误码</a>。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>状态码的描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>OSS配置信息。</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetSmsOcrOssInfoResponseBodyModel Model { get; set; }
        public class GetSmsOcrOssInfoResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>签名使用的 AccessKey ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>bypFNbG******</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>bucket名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>过期时间戳，单位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741521339</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Host 地址。</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://***.oss-cn-zhangjiakou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>签名策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0wMy0wOVQxMTo1NTozOS4wMDFaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsMTA0ODU3NjAwMF0seyJidWNrZXQiOiJhbGljb20tZmMtbWVkaWEifSxbImVxIiwiJGtleSIsIjEwMDAwMDM1ODA4MjA2M1wv********</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>根据 AccessKey Secret 和 Policy 计算出的签名信息。调用 OSS API 时，OSS 验证该签名信息，从而确认请求的合法性。</para>
            /// 
            /// <b>Example:</b>
            /// <para>QvNTGC9DSLTeByP+ZWW******</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>策略路径。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000********001</para>
            /// </summary>
            [NameInMap("StartPath")]
            [Validation(Required=false)]
            public string StartPath { get; set; }

        }

        /// <summary>
        /// <para>本次调用请求的 ID，是由阿里云为该请求生成的唯一标识符，可用于排查和定位问题。</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D5AFDE-xxxx-132E-8909-1FDC071DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>调用接口是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>true：调用成功。</para>
        /// </description></item>
        /// <item><description><para>false：调用失败。</para>
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
