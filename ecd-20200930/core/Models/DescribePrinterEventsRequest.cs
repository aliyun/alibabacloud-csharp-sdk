// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePrinterEventsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud desktop ID. If you do not specify this parameter, the system queries all cloud desktops in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The cloud desktop name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop-001</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC. If you do not specify this parameter, the current time is used.<br><a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The logon user information, which is the RAM user ID or the Active Directory (AD) username. If you do not specify this parameter, the system queries the events of all users in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user001</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The list of end user IDs.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page during paging.
        /// Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. The value is the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The printer driver name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HP LaserJet PCL 6</para>
        /// </summary>
        [NameInMap("PrinterDriver")]
        [Validation(Required=false)]
        public string PrinterDriver { get; set; }

        /// <summary>
        /// <para>The printer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HP LaserJet Pro</para>
        /// </summary>
        [NameInMap("PrinterName")]
        [Validation(Required=false)]
        public string PrinterName { get; set; }

        /// <summary>
        /// <para>The printer redirection type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PrinterRedirType")]
        [Validation(Required=false)]
        public int? PrinterRedirType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the list of regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC. If you do not specify this parameter, the system queries events prior to the time specified by <c>EndTime</c>.<br><a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-23T04:10:21Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
