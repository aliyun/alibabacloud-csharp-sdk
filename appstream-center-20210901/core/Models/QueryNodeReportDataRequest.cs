// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryNodeReportDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specific app instance group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. If you do not specify this parameter, data is not filtered by app instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the business region, which is used to filter report data. You can call the <a href="~~ListRegions~~">ListRegions</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end time of the statistics. This parameter is <b>required</b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The end time cannot be earlier than StartDate. The query span must meet the limits corresponding to StatDateType. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Specify a value starting from 1. If you do not specify this parameter, the service returns the first page, but the response may echo 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. If you do not specify this parameter, the default value 200 is used. If the specified value is greater than 1,500, the value 1,500 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is optional. If you do not specify this parameter, data is queried for Wuying Cloud App.</para>
        /// <para>Specify the value in the exact case shown below. Data that cannot be matched is not returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: Wuying Cloud App.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud Browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise Edition workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Linggou Team Edition container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Linggou Dedicated Edition container workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud Phone.</description></item>
        /// <item><description><c>AIAgent</c>: AgentBay (AI agent).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the statistics. This parameter is <b>required</b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The <c>1d</c> granularity calculates statistics by date, while other granularities are accurate to the minute. The query includes both the start and end boundaries. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical granularity. This parameter is <b>required</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>1m</c>: aggregates data by 1 minute. The maximum query span is 1 day.</description></item>
        /// <item><description><c>30m</c>: aggregates data by 30 minutes. The maximum query span is 1 day.</description></item>
        /// <item><description><c>6h</c>: aggregates data by 6 hours. The maximum query span is 15 days.</description></item>
        /// <item><description><c>1d</c>: aggregates data by day. The maximum query span is 180 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("StatDateType")]
        [Validation(Required=false)]
        public string StatDateType { get; set; }

    }

}
