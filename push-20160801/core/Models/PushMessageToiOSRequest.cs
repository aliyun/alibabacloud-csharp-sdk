// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushMessageToiOSRequest : TeaModel {
        /// <summary>
        /// <para>AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24780725</para>
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
        /// <para>The custom ID for the push Job. If JobKey is not empty, this field is included in the receipt log. For receipt logs, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt Logs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <para>Whether to store the message offline. StoreOffline is set to false by default.</para>
        /// <para>If stored, and the user is offline during the push, the message is sent again when the user comes online within the time-to-live (TTL). The default time-to-live (TTL) is 72 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StoreOffline")]
        [Validation(Required=false)]
        public bool? StoreOffline { get; set; }

        /// <summary>
        /// <para>Push target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEVICE</b>: Push by device</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: Push by account</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: Push by alias</para>
        /// </description></item>
        /// <item><description><para><b>TAG</b>: Push by tag</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: Push to all devices</para>
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
        /// <para>Set based on Target. Separate multiple values with commas. If the limit is exceeded, push multiple times.</para>
        /// <list type="bullet">
        /// <item><description><para>Target=DEVICE. Example values: <c>deviceid111,deviceid1111</c> (supports up to 1,000).</para>
        /// </description></item>
        /// <item><description><para>Target=ACCOUNT. Example values: <c>account111,account222</c> (supports up to 1,000).</para>
        /// </description></item>
        /// <item><description><para>Target=ALIAS. Example values: <c>alias111,alias222</c> (supports up to 1,000).</para>
        /// </description></item>
        /// <item><description><para>Target=TAG. Supports single and multiple tags. For format, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag Format</a>.</para>
        /// </description></item>
        /// <item><description><para>Target=ALL. Value is <b>all</b>.</para>
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
