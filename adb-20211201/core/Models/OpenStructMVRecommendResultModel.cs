// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMVRecommendResultModel : TeaModel {
        /// <summary>
        /// <para>The number of accelerated queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("AcceleratedQueriesCount")]
        [Validation(Required=false)]
        public long? AcceleratedQueriesCount { get; set; }

        /// <summary>
        /// <para>The base table associated with the subquery.</para>
        /// </summary>
        [NameInMap("BaseTables")]
        [Validation(Required=false)]
        public List<OpenStructMvBaseTableDetailModel> BaseTables { get; set; }

        /// <summary>
        /// <para>Estimated bytes scanned reduction by current materialized view from correlated parent queries (posterior calculation).</para>
        /// 
        /// <b>Example:</b>
        /// <para>321321223</para>
        /// </summary>
        [NameInMap("SavedScanbytes")]
        [Validation(Required=false)]
        public long? SavedScanbytes { get; set; }

        /// <summary>
        /// <para>The extracted public subquery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM demo.tbl</para>
        /// </summary>
        [NameInMap("Subquery")]
        [Validation(Required=false)]
        public string Subquery { get; set; }

        /// <summary>
        /// <para>The ID of the subquery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SubqueryId")]
        [Validation(Required=false)]
        public long? SubqueryId { get; set; }

        /// <summary>
        /// <para>Whether the current subquery supports incremental refresh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportIncrementalRefresh")]
        [Validation(Required=false)]
        public bool? SupportIncrementalRefresh { get; set; }

    }

}
