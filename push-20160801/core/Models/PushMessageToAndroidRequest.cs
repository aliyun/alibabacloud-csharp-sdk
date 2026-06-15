// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushMessageToAndroidRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The content of the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my body</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>A custom ID for the push task. If \<c>JobKey\\</c> is not empty, this field is included in the receipt logs. For more information, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to store the message offline. The default value is false.</para>
        /// <para>If you store the message and the user is offline, the message is sent again when the user comes online within the time-to-live (TTL) period. The default TTL is 72 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StoreOffline")]
        [Validation(Required=false)]
        public bool? StoreOffline { get; set; }

        /// <summary>
        /// <para>The push target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEVICE</b>: Pushes messages to devices.</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: Pushes messages to accounts.</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: Pushes messages to aliases.</para>
        /// </description></item>
        /// <item><description><para><b>TAG</b>: Pushes messages to tags.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: Pushes messages to all devices.</para>
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
        /// <para>Set this parameter based on the value of \<c>Target\\</c>. Use commas (,) to separate multiple values. If you exceed the limit, send the pushes in batches.</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>Target\\</c> is set to \<c>DEVICE\\</c>, specify device IDs. Example: <c>deviceid111,deviceid1111</c>. You can specify up to 1,000 device IDs.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is set to \<c>ACCOUNT\\</c>, specify account IDs. Example: <c>account111,account222</c>. You can specify up to 1,000 account IDs.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is set to \<c>ALIAS\\</c>, specify aliases. Example: <c>alias111,alias222</c>. You can specify up to 1,000 aliases.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is set to \<c>TAG\\</c>, you can specify one or more tags. For more information about the format, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag format</a>.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is set to \<c>ALL\\</c>, set the value to <b>all</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

        /// <summary>
        /// <para>The title of the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
