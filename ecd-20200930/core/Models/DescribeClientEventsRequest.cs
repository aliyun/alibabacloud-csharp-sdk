// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud desktop. If you omit this parameter, the operation returns events for all cloud desktops in the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-8fupvkhg0aayu****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The IP address of the cloud desktop. If you omit this parameter, the operation returns events for all cloud desktops in the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.<em>.</em></para>
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
        /// <remarks>
        /// <para>This parameter is not in use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>To be hidden.</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.<br>
        /// If you omit this parameter, the operation uses the current time.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the end user, which can be a RAM user ID or an AD username. If you omit this parameter, the operation returns events for all users in the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28961708130834****</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The event type to query. If EventTypes is specified, this parameter is ignored. If you omit both this parameter and EventTypes, the operation returns all events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP_DISCONNECT</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>An array of event types to query. The operation returns events that match any of the specified types.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        [NameInMap("FillHardwareInfo")]
        [Validation(Required=false)]
        public bool? FillHardwareInfo { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.<br>
        /// Default value: 100.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous response to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the office network to which the cloud desktop belongs. If you omit this parameter, the operation returns events for users in all office networks in the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-bh77qa8nmjot4****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The name of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.<br>
        /// If you omit this parameter, the query returns events that occurred before the time specified by <c>EndTime</c>.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
