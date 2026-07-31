// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvDetailModel : TeaModel {
        /// <summary>
        /// <para>All direct parent base tables of the materialized view.</para>
        /// </summary>
        [NameInMap("BaseTableInfos")]
        [Validation(Required=false)]
        public List<OpenStructMvDetailModelBaseTableInfos> BaseTableInfos { get; set; }
        public class OpenStructMvDetailModelBaseTableInfos : TeaModel {
            /// <summary>
            /// <para>Whether the base table is a materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BaseTableIsMv")]
            [Validation(Required=false)]
            public bool? BaseTableIsMv { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The table engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XUANWU</para>
            /// </summary>
            [NameInMap("TableEngine")]
            [Validation(Required=false)]
            public string TableEngine { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_tbl</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>All direct parent base tables of the materialized view.</para>
        /// </summary>
        [NameInMap("BaseTableNames")]
        [Validation(Required=false)]
        public List<List<string>> BaseTableNames { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable alerting for refresh latency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDelayAlert")]
        [Validation(Required=false)]
        public int? EnableDelayAlert { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable alerting for refresh task failures. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableFailureAlert")]
        [Validation(Required=false)]
        public int? EnableFailureAlert { get; set; }

        /// <summary>
        /// <para>The total number of explicit query hits in the last 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExplicitHit")]
        [Validation(Required=false)]
        public long? ExplicitHit { get; set; }

        /// <summary>
        /// <para>The time of the first refresh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 09:00:00</para>
        /// </summary>
        [NameInMap("FirstRefreshTime")]
        [Validation(Required=false)]
        public string FirstRefreshTime { get; set; }

        /// <summary>
        /// <para>The total number of implicit query hits in the last 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ImplicitHit")]
        [Validation(Required=false)]
        public long? ImplicitHit { get; set; }

        /// <summary>
        /// <para>Indicates whether the materialized view has not been accessed by explicit or implicit queries for more than 30 days since its creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsInactive")]
        [Validation(Required=false)]
        public bool? IsInactive { get; set; }

        /// <summary>
        /// <para>The refresh latency toleration, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LatencyTolerance")]
        [Validation(Required=false)]
        public int? LatencyTolerance { get; set; }

        /// <summary>
        /// <para>The disk space that the materialized view occupies for hot data, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("LocalSize")]
        [Validation(Required=false)]
        public long? LocalSize { get; set; }

        /// <summary>
        /// <para>Whether query rewrite is enabled for the materialized view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryRewriteEnabled")]
        [Validation(Required=false)]
        public bool? QueryRewriteEnabled { get; set; }

        /// <summary>
        /// <para>The refresh interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(now() + INTERVAL \&quot;10\&quot; SECOND)</para>
        /// </summary>
        [NameInMap("RefreshInterval")]
        [Validation(Required=false)]
        public string RefreshInterval { get; set; }

        /// <summary>
        /// <para>The refresh model of the materialized view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAST</para>
        /// </summary>
        [NameInMap("RefreshState")]
        [Validation(Required=false)]
        public string RefreshState { get; set; }

        /// <summary>
        /// <para>The disk space that the materialized view occupies for cold data, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RemoteSize")]
        [Validation(Required=false)]
        public long? RemoteSize { get; set; }

        /// <summary>
        /// <para>The resource group on which the refresh depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The table engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XUANWU</para>
        /// </summary>
        [NameInMap("TableEngine")]
        [Validation(Required=false)]
        public string TableEngine { get; set; }

        /// <summary>
        /// <para>The time of the last refresh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 10:00:00</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
