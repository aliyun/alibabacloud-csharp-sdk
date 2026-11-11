// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QuerySessionDataRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID, used to filter session data for a specified delivery group. If not provided, the summary of session data for all delivery groups under the current account is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-89ibriac2wudyph38</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The business region ID, which specifies the region for which to query session data. The server uses this value as the region filter condition for session data. If not provided, no region filtering is applied, and the summary of session data for all regions is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The region ID, which is a common request parameter for the gateway. The region actually used to filter session data in this operation is specified by BizRegionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The statistical date in the yyyyMMdd format (without hyphens), such as 20261106. If not provided, the data for yesterday is queried by default. Only dates within the last 90 days are supported. If the date exceeds 90 days or the format is invalid, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20261106</para>
        /// </summary>
        [NameInMap("StatDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
