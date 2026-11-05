// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserAppUsageAggregateByHourRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specified app instance group. If this parameter is not provided, data is not filtered by app instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The business region ID, which is used to filter application usage data. If this parameter is not provided, data is not filtered by business region. You can call <a href="~~ListRegions~~">ListRegions</a> to obtain the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end date for statistics in the yyyyMMdd format. If this parameter is not provided, it defaults to yesterday. The date cannot be earlier than StartDate or 90 days before the call date. The query range includes this date. The date is interpreted as a calendar date in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260907</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The region ID for OpenAPI access, which is used for request authentication and routing. To filter business data by region, use BizRegionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start date for statistics in the yyyyMMdd format. If this parameter is not provided, it defaults to yesterday. The date cannot be earlier than 90 days before the call date. The query range includes this date. The date is interpreted as a calendar date in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260901</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The ID of the end user to query. This parameter must be explicitly provided. If it is not provided, no matching records are usually returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
