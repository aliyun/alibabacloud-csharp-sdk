// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryNodeReportDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specified app instance group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. If you do not specify this parameter, data is not filtered by app instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The business region ID, which is used to filter report data. You can call the <a href="~~ListRegions~~">ListRegions</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end time of the statistics. This parameter is required. Format: yyyy-MM-dd HH:mm:ss. The end time cannot be earlier than the start time. The query span must meet the limit corresponding to the statistical granularity. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page number to query. Explicitly pass a value starting from 1. If you do not specify this parameter, the service processes the request as the first page, but the response may return 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. If you do not specify this parameter, the default value is 200. If the value is greater than 1500, it is processed as 1500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is optional. If you do not specify this parameter, data is queried for Wuying Cloud App.</para>
        /// <para>Specify the value in the exact case shown below. Data that does not match the specified case is not returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Wuying Cloud App.</description></item>
        /// <item><description>CloudBrowser: Cloud Browser.</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation.</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou container workstation.</description></item>
        /// <item><description>WuyingWorkstationTeam: Linggou Team Edition container workstation.</description></item>
        /// <item><description>WuyingWorkstationBusiness: Linggou Dedicated Edition container workstation.</description></item>
        /// <item><description>AndroidCloud: Cloud Phone.</description></item>
        /// <item><description>AIAgent: AgentBay (AI agent).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the statistics. This parameter is required. Format: yyyy-MM-dd HH:mm:ss. The 1d granularity aggregates data by date, while other granularities aggregate data down to the minute. The query includes both the start and end boundaries. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical granularity. This parameter is required.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1m: Aggregates data by 1 minute. The maximum query span is 1 day.</description></item>
        /// <item><description>30m: Aggregates data by 30 minutes. The maximum query span is 1 day.</description></item>
        /// <item><description>6h: Aggregates data by 6 hours. The maximum query span is 15 days.</description></item>
        /// <item><description>1d: Aggregates data by day. The maximum query span is 180 days.</description></item>
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
