// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateDigitalSignOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if the RAM user is not authorized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <c>OK</c> is returned.</para>
        /// </description></item>
        /// <item><description><para>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">API error codes</a>.</para>
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
        /// <para>The returned data.</para>
        /// <list type="bullet">
        /// <item><description><para><c>signName</c>: The name of the signature.</para>
        /// </description></item>
        /// <item><description><para><c>signOrderId</c>: The ID of the signature order.</para>
        /// </description></item>
        /// <item><description><para><c>signCode</c>: The code of the signature.</para>
        /// </description></item>
        /// <item><description><para><c>signId</c>: The ID of the signature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;signId\&quot;: \&quot;2006746****\&quot;, \&quot;signCode\&quot;: \&quot;SIGN_100000184736042_174416475****_hpMd1\&quot;, \&quot;signOrderId\&quot;: 2246979****, \&quot;signName\&quot;: u\&quot;\u8d5b\u745e\u5a05\u808c\u80a4\u7ba1\u7406\&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D0133B9-6C0D-0BAE-8161-1EEF9E2D4069</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
