// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushNoticeToAndroidRequest : TeaModel {
        /// <summary>
        /// <para>Your AppKey.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The body of the notification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Custom key-value pairs for Android-specific extensions. Pass this as a JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
        /// </summary>
        [NameInMap("ExtParameters")]
        [Validation(Required=false)]
        public string ExtParameters { get; set; }

        /// <summary>
        /// <para>A custom ID for the push task. If you specify a non-empty JobKey, it appears in the delivery receipt log. For more information, see <a href="https://help.aliyun.com/document_detail/434651.html">Delivery receipt logs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <para>Whether to store the notification for offline delivery. Default: false.</para>
        /// <para>If enabled, the notification is redelivered when the user comes online within the time-to-live (TTL) period. Default TTL: 72 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StoreOffline")]
        [Validation(Required=false)]
        public bool? StoreOffline { get; set; }

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
        /// <para>Set this based on the Target value. Separate multiple values with commas. If you exceed the limit, send multiple requests.</para>
        /// <list type="bullet">
        /// <item><description><para>If Target=DEVICE, use values such as <c>deviceid111,deviceid1111</c>. Maximum: 1000 devices.</para>
        /// </description></item>
        /// <item><description><para>If Target=ACCOUNT, use values such as <c>account111,account222</c>. Maximum: 1000 accounts.</para>
        /// </description></item>
        /// <item><description><para>If Target=ALIAS, use values such as <c>alias111,alias222</c>. Maximum: 1000 aliases.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
