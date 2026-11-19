// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetJobNameListRequest : TeaModel {
        /// <summary>
        /// <para>The end time in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-24 10:01:55</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The query conditions. This parameter is required and must be a valid JSON query condition, such as {&quot;TaskId&quot;:&quot;P_11TL5T&quot;}. Before calling this operation, call GetStockOssCheckTasksList to obtain an available TaskId. If this parameter is not provided, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TaskId&quot;:&quot;P_11TL5T&quot;}</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;StartTime&quot;:&quot;desc&quot;}</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public Dictionary<string, string> Sort { get; set; }

        /// <summary>
        /// <para>The start time in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-11 09:00:19</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
