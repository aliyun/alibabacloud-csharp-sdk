// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeIMVInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The queried materialized views.</para>
        /// </summary>
        [NameInMap("ImvInfos")]
        [Validation(Required=false)]
        public List<DescribeIMVInfosResponseBodyImvInfos> ImvInfos { get; set; }
        public class DescribeIMVInfosResponseBodyImvInfos : TeaModel {
            /// <summary>
            /// <para>The name of the table based on which the materialized view is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;public.&quot;t2&quot;</para>
            /// </summary>
            [NameInMap("Base")]
            [Validation(Required=false)]
            public string Base { get; set; }

            /// <summary>
            /// <para>The dependency between the materialized view and the base table and all metric values, which can be used to build a lineage graph.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;maintenance_calls\&quot; : 1, \&quot;avg_apply_time\&quot; : 2, \&quot;avg_calc_rows\&quot; : 1, \&quot;avg_calc_time\&quot; : 11, \&quot;avg_delta_rows\&quot; : 1, \&quot;avg_maintenance_total_time\&quot; : 14, \&quot;avg_maintenance_total_time_total\&quot; : 14, \&quot;max_apply_time\&quot; : 2, \&quot;max_calc_rows\&quot; : 1, \&quot;max_calc_time\&quot; : 11, \&quot;max_delta_rows\&quot; : 1, \&quot;max_maintenance_total_time\&quot; : 14, \&quot;max_maintenance_total_time_total\&quot; : 14, \&quot;min_apply_time\&quot; : 2, \&quot;min_calc_rows\&quot; : 1, \&quot;min_calc_time\&quot; : 11, \&quot;min_delta_rows\&quot; : 1, \&quot;min_maintenance_total_time\&quot; : 14, \&quot;min_maintenance_total_time_total\&quot; : 14, \&quot;max_outerjoin_apply_time\&quot; : null, \&quot;max_outerjoin_calc_rows\&quot; : null, \&quot;max_outerjoin_calc_time\&quot; : null, \&quot;max_outerjoin_delta_rows\&quot; : null, \&quot;avg_outerjoin_apply_time\&quot; : null, \&quot;avg_outerjoin_calc_rows\&quot; : null, \&quot;avg_outerjoin_calc_time\&quot; : null, \&quot;avg_outerjoin_delta_rows\&quot; : null, \&quot;min_outerjoin_apply_time\&quot; : null, \&quot;min_outerjoin_calc_rows\&quot; : null, \&quot;min_outerjoin_calc_time\&quot; : null, \&quot;min_outerjoin_delta_rows\&quot; : null, \&quot;create_rows\&quot; : null, \&quot;create_time\&quot; : null, \&quot;direct_visited\&quot; : null, \&quot;indirect_visited\&quot; : null, \&quot;max_refresh_rows\&quot; : null, \&quot;max_refresh_time\&quot; : null, \&quot;avg_refresh_rows\&quot; : null, \&quot;avg_refresh_time\&quot; : null, \&quot;min_refresh_rows\&quot; : null, \&quot;min_refresh_time\&quot; : null, \&quot;refresh_calls\&quot; : null, \&quot;avg_wait_lock_time\&quot; : null, \&quot;max_wait_lock_time\&quot; : null, \&quot;min_wait_lock_time\&quot; : null, \&quot;latest_maintenance_time\&quot; : \&quot;2023-08-09T07:39:14.753252+00:00\&quot;}</para>
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public string DetailInfo { get; set; }

            /// <summary>
            /// <para>The name of the materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public.&quot;mv1&quot;</para>
            /// </summary>
            [NameInMap("MV")]
            [Validation(Required=false)]
            public string MV { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
