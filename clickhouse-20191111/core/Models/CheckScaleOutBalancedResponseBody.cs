// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckScaleOutBalancedResponseBody : TeaModel {
        /// <summary>
        /// <para>The check result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>400</b>: The cluster failed the check.</description></item>
        /// <item><description><b>200</b>: The cluster passed the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CheckCode")]
        [Validation(Required=false)]
        public string CheckCode { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error information returned for a check failure.</para>
        /// </summary>
        [NameInMap("TableDetails")]
        [Validation(Required=false)]
        public CheckScaleOutBalancedResponseBodyTableDetails TableDetails { get; set; }
        public class CheckScaleOutBalancedResponseBodyTableDetails : TeaModel {
            [NameInMap("TableDetail")]
            [Validation(Required=false)]
            public List<CheckScaleOutBalancedResponseBodyTableDetailsTableDetail> TableDetail { get; set; }
            public class CheckScaleOutBalancedResponseBodyTableDetailsTableDetail : TeaModel {
                /// <summary>
                /// <para>The cluster. The value is fixed as <b>default</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_name</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The error details. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The unique distributed table is missing.</description></item>
                /// <item><description><b>2</b>: More than one distributed table exists for the local table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public int? Detail { get; set; }

                /// <summary>
                /// <para>The name of the local table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>The amount of time that is required for the migration and scale-out. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TimeDuration")]
        [Validation(Required=false)]
        public string TimeDuration { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
