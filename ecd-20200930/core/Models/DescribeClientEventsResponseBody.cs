// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of user events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeClientEventsResponseBodyEvents> Events { get; set; }
        public class DescribeClientEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112259558861****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The number of bytes received.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8665</para>
            /// </summary>
            [NameInMap("BytesReceived")]
            [Validation(Required=false)]
            public string BytesReceived { get; set; }

            /// <summary>
            /// <para>The number of bytes sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("BytesSend")]
            [Validation(Required=false)]
            public string BytesSend { get; set; }

            /// <summary>
            /// <para>The IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.68.<em>.</em></para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The operating system of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Darwin 17.7.0 x64</para>
            /// </summary>
            [NameInMap("ClientOS")]
            [Validation(Required=false)]
            public string ClientOS { get; set; }

            /// <summary>
            /// <para>The client version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.4 202012021700</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the desktop group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-kadkdfaf****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The name of the desktop group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-8fupvkhg0aayu****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The IP address of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
            /// </summary>
            [NameInMap("DesktopIp")]
            [Validation(Required=false)]
            public string DesktopIp { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop\&quot;s directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-bh77qa8nmjot4****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The ID of the end user. The value can be the ID of a RAM user or the username of an AD user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28961708130834****</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5651188b-3070-d1cc-5311-75753d59****</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The time the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DESKTOP_DISCONNECT</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop\&quot;s office site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-bh77qa8nmjot4****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The name of the office site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The type of account system for the office site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the event. This parameter is returned for <c>DESKTOP_DISCONNECT</c> and <c>GET_CONNECTION_TICKET</c> events. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>200</c>: Success.</para>
            /// </description></item>
            /// <item><description><para>An error message, such as <c>FailedToGetConnectionTicket</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TerminalInfo")]
            [Validation(Required=false)]
            public DescribeClientEventsResponseBodyEventsTerminalInfo TerminalInfo { get; set; }
            public class DescribeClientEventsResponseBodyEventsTerminalInfo : TeaModel {
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination token. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28A40F12-F340-442B-A35F-46EF6A03227B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
