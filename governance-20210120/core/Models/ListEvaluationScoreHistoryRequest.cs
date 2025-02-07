// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationScoreHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member. This parameter takes effect only when a multi-account governance maturity check is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the YYYY-MM-DD format.</para>
        /// <para>By default, the historical scores that were generated in the seven days before the current date are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-11</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the YYYY-MM-DD format.</para>
        /// <para>You can query the historical scores within the previous 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-11</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
