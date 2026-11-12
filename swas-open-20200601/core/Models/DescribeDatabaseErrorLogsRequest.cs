// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseErrorLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the lightweight database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db-38263fa955774501a2ae1bdaed6f****</para>
        /// </summary>
        [NameInMap("DatabaseInstanceId")]
        [Validation(Required=false)]
        public string DatabaseInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time must be in UTC and formatted as <c>yyyy-MM-ddTHH:mmZ</c> according to the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard. This value must be later than the start time.</para>
        /// <remarks>
        /// <para>The time displayed in the console is 8 hours ahead of the specified UTC time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-08T04:04Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of error logs to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the lightweight database instance resides.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The time must be in UTC and formatted as <c>yyyy-MM-ddTHH:mmZ</c> according to the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard.</para>
        /// <remarks>
        /// <para>The time displayed in the console is 8 hours ahead of the specified UTC time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-07T04:04Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
