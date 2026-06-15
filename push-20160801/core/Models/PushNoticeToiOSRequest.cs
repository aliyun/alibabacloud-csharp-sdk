// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushNoticeToiOSRequest : TeaModel {
        /// <summary>
        /// <para>iOS notifications use Apple’s APNs service. Specify the environment.</para>
        /// <list type="bullet">
        /// <item><description><para>DEV: Development environment.</para>
        /// </description></item>
        /// <item><description><para>PRODUCT: Production environment.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("ApnsEnv")]
        [Validation(Required=false)]
        public string ApnsEnv { get; set; }

        /// <summary>
        /// <para>Your AppKey.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24780725</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The body text of the notification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello World</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>A custom key-value map for developer extensions.</para>
        /// <remarks>
        /// <para>For iOS devices, pass this parameter as a JSON object. Otherwise, parsing fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;ios&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("ExtParameters")]
        [Validation(Required=false)]
        public string ExtParameters { get; set; }

        /// <summary>
        /// <para>A custom ID for the push task. If you specify a JobKey, the delivery log includes this field. For more information, see <a href="https://help.aliyun.com/document_detail/434651.html">Delivery logs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <para>The target of the push. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEVICE</b>: Push to specific devices.</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: Push to specific accounts.</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: Push to users with specific aliases.</para>
        /// </description></item>
        /// <item><description><para><b>TAG</b>: Push to users with specific tags.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: Push to all devices.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>Values depend on the Target value. Separate multiple values with commas. If you exceed the limit, send multiple requests.</para>
        /// <list type="bullet">
        /// <item><description><para>If Target=DEVICE, use values such as <c>deviceid111,deviceid1111</c>. Maximum: 1000.</para>
        /// </description></item>
        /// <item><description><para>If Target=ACCOUNT, use values such as <c>account111,account222</c>. Maximum: 1000.</para>
        /// </description></item>
        /// <item><description><para>If Target=ALIAS, use values such as <c>alias111,alias222</c>. Maximum: 1000.</para>
        /// </description></item>
        /// <item><description><para>If Target=TAG, support single or multiple tags. For format details, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag format</a>.</para>
        /// </description></item>
        /// <item><description><para>If Target=ALL, set this to <b>ALL</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

        /// <summary>
        /// <para>The title of the notification.</para>
        /// <list type="bullet">
        /// <item><description><para>iOS 10 and later: Displays as the notification title.</para>
        /// </description></item>
        /// <item><description><para>iOS 8.2 through iOS 9.x: Replaces the app name in the notification.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
