// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud desktop ID. If you do not specify a value for this parameter, events of all cloud desktops in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-8fupvkhg0aayu****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The IP address of the cloud desktop. If you do not specify a value for this parameter, the events of all cloud desktops in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.<em>.</em></para>
        /// </summary>
        [NameInMap("DesktopIp")]
        [Validation(Required=false)]
        public string DesktopIp { get; set; }

        /// <summary>
        /// <para>The cloud desktop name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>This parameter is not available to the public.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-bh77qa8nmjot4****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.\
        /// If you do not specify a value for this parameter, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The information about the end user that connects to the cloud desktop from the Elastic Desktop Service (EDS) client. The information can be a Resource Access Management (RAM) user ID or an Active Directory (AD) username. If you do not specify a value for this parameter, the events of all end users in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28961708130834****</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The type of the events that you want to query. If you specify multiple values for the EventTypes parameter, the events of all specified types are returned. If you do not specify values for the EventTypes and EventType parameters, all events of end users in the specified region are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DESKTOP_STOP: End users stop the cloud desktop.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>GET_LITE_CONNECTION_TICKET: End users obtain the credential for reconnecting to the cloud desktop upon disconnection.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DESKTOP_DISCONNECT: End users disconnect desktop sessions.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>GET_CONNECTION_TICKET: End users request to connect to the cloud desktop.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CLIENT_LOGIN: End users log on to the cloud desktop.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DESKTOP_REBOOT: End users restart the cloud desktop.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DESKTOP_CONNECT: End users establish desktop sessions.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DESKTOP_START: End users start the cloud desktop.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP_DISCONNECT</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The array of event types that you want to query. You can specify multiple event types. The response contains all or specified types of events.</para>
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
        /// <para>The number of entries per page.\
        /// Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the cloud desktop belongs. If you do not specify a value for this parameter, the events of all workspaces in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-bh77qa8nmjot4****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.\
        /// If you do not specify a value for this parameter, all events that occurred before the point in time that you specify for <c>EndTime</c> are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
