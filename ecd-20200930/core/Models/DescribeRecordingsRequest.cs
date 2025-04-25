// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordingsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer ID. If this parameter is not specified, the screen recording files on all cloud computers in the designated region will be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-hlh41mk78dugw****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the <c>YYYYMMDDhhmmss</c> format. The time must be in UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230424004441</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a URL.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedSignedUrl")]
        [Validation(Required=false)]
        public bool? NeedSignedUrl { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGN4YzAxQGNuLWhhbmd6aG91LjExNzU5NTMyNjgzMTQ1****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-gx2x1dhsmthe9****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The validity period of the returned URL. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SignedUrlExpireMinutes")]
        [Validation(Required=false)]
        public int? SignedUrlExpireMinutes { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the ISO 8601 standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-27T02:30:10Z</para>
        /// </summary>
        [NameInMap("StandardEndTime")]
        [Validation(Required=false)]
        public string StandardEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the ISO 8601 standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-27T02:20:10Z</para>
        /// </summary>
        [NameInMap("StandardStartTime")]
        [Validation(Required=false)]
        public string StandardStartTime { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <c>YYYYMMDDhhmmss</c> format. The time must be in UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230424000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
