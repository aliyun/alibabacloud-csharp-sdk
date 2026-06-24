// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationScoreHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member accounts. This parameter is applicable only to the multi-account detection pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The end date of the query. Format: YYYY-MM-DD.</para>
        /// <para>By default, the historical scores from the last 7 days are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-11</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("EvaluationDomain")]
        [Validation(Required=false)]
        public string EvaluationDomain { get; set; }

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
        /// <para>The start date of the query. Format: YYYY-MM-DD.</para>
        /// <para>You can query records from the last 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-11</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
