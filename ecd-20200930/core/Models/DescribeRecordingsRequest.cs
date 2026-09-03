// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordingsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer ID. If you do not specify this parameter, all cloud computers in the region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-hlh41mk78dugw****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in UTC+8 in the <c>YYYYMMDDhhmmss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230424004441</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
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
        /// <para>Specifies whether to return the URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedSignedUrl")]
        [Validation(Required=false)]
        public bool? NeedSignedUrl { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous call to this operation. You do not need to set this parameter for the first request.</para>
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
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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
        /// <para>The end time of the query. Specify the time in the ISO 8601 standard in UTC+0 in the <c>yyyy-mm-ddthh:mm:ssz</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-27T02:30:10Z</para>
        /// </summary>
        [NameInMap("StandardEndTime")]
        [Validation(Required=false)]
        public string StandardEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the ISO 8601 standard in UTC+0 in the <c>yyyy-mm-ddthh:mm:ssz</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-27T02:20:10Z</para>
        /// </summary>
        [NameInMap("StandardStartTime")]
        [Validation(Required=false)]
        public string StandardStartTime { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in UTC+8 in the <c>YYYYMMDDhhmmss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230424000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
