// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniRecoverableListResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msdb</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>An array that consists of the backup snapshots.</para>
        /// </summary>
        [NameInMap("RecoverableInfoList")]
        [Validation(Required=false)]
        public List<DescribeUniRecoverableListResponseBodyRecoverableInfoList> RecoverableInfoList { get; set; }
        public class DescribeUniRecoverableListResponseBodyRecoverableInfoList : TeaModel {
            /// <summary>
            /// <para>The timestamp of the first backup. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671468180000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last backup. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671468180000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The identifier of the point in time for restoration in the backup version that is used. The database is an Oracle database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4529940.0</para>
            /// </summary>
            [NameInMap("ResetScn")]
            [Validation(Required=false)]
            public string ResetScn { get; set; }

            /// <summary>
            /// <para>The point in time for restoration in the backup version that is used. The database is an Oracle database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-30 08:04:36</para>
            /// </summary>
            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public long? ResetTime { get; set; }

            /// <summary>
            /// <para>The information about the database. This parameter is available when the database is a Microsoft SQL Server (MSSQL) database. The value is a JSON string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>name</b>: the name of the database</description></item>
            /// <item><description><b>files</b>: the path to the database files</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;files&quot;: {
            ///             &quot;qtc&quot;: &quot;F:\\database\\qtc.mdf&quot;,
            ///             &quot;qtc_log&quot;: &quot;F:\\database\\qtc_0.ldf&quot;
            ///       },
            ///       &quot;name&quot;: &quot;qtc&quot;
            /// }</para>
            /// </summary>
            [NameInMap("RestoreInfo")]
            [Validation(Required=false)]
            public string RestoreInfo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D0760****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
