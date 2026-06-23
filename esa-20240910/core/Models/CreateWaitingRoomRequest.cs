// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWaitingRoomRequest : TeaModel {
        /// <summary>
        /// <para>The custom cookie name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>__aliwaitingroom_example</para>
        /// </summary>
        [NameInMap("CookieName")]
        [Validation(Required=false)]
        public string CookieName { get; set; }

        /// <summary>
        /// <para>The custom waiting room page content. This parameter is required when the waiting room type is set to custom. The content must use Base64 encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SGVsbG8gd29ybGQ=</para>
        /// </summary>
        [NameInMap("CustomPageHtml")]
        [Validation(Required=false)]
        public string CustomPageHtml { get; set; }

        /// <summary>
        /// <para>The description of the waiting room.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DisableSessionRenewalEnable")]
        [Validation(Required=false)]
        public string DisableSessionRenewalEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the waiting room. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The hostname and path configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HostNameAndPath")]
        [Validation(Required=false)]
        public List<CreateWaitingRoomRequestHostNameAndPath> HostNameAndPath { get; set; }
        public class CreateWaitingRoomRequestHostNameAndPath : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The path.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The subdomain.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.</para>
            /// </summary>
            [NameInMap("Subdomain")]
            [Validation(Required=false)]
            public string Subdomain { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable JSON response. When enabled, requests with an Accept header containing &quot;application/json&quot; return JSON data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("JsonResponseEnable")]
        [Validation(Required=false)]
        public string JsonResponseEnable { get; set; }

        /// <summary>
        /// <para>The language of the waiting room page. This parameter is required when the waiting room type is set to default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enus</b>: English.</description></item>
        /// <item><description><b>zhcn</b>: Simplified Chinese.</description></item>
        /// <item><description><b>zhhk</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enus</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the waiting room.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waitingroom_example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of new users per minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("NewUsersPerMinute")]
        [Validation(Required=false)]
        public string NewUsersPerMinute { get; set; }

        /// <summary>
        /// <para>Specifies whether to queue all visitors. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("QueueAllEnable")]
        [Validation(Required=false)]
        public string QueueAllEnable { get; set; }

        /// <summary>
        /// <para>The queuing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>random</b>: Random.</description></item>
        /// <item><description><b>fifo</b>: First in, first out.</description></item>
        /// <item><description><b>passthrough</b>: Passthrough.</description></item>
        /// <item><description><b>reject-all</b>: Reject all.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fifo</para>
        /// </summary>
        [NameInMap("QueuingMethod")]
        [Validation(Required=false)]
        public string QueuingMethod { get; set; }

        /// <summary>
        /// <para>The waiting room status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b></description></item>
        /// <item><description><b>202</b></description></item>
        /// <item><description><b>429</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("QueuingStatusCode")]
        [Validation(Required=false)]
        public string QueuingStatusCode { get; set; }

        /// <summary>
        /// <para>The session duration, in minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The total number of active users.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalActiveUsers")]
        [Validation(Required=false)]
        public string TotalActiveUsers { get; set; }

        /// <summary>
        /// <para>The type of the waiting room. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: Default type.</description></item>
        /// <item><description><b>custom</b>: Custom type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WaitingRoomType")]
        [Validation(Required=false)]
        public string WaitingRoomType { get; set; }

    }

}
