// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSynDbsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7655F5F9-1313-5ABA-8516-F6EB79605A5F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about data synchronization between the ApsaraDB for ClickHouse cluster and an ApsaraDB RDS for MySQL instance.</para>
        /// </summary>
        [NameInMap("SynDbs")]
        [Validation(Required=false)]
        public List<DescribeSynDbsResponseBodySynDbs> SynDbs { get; set; }
        public class DescribeSynDbsResponseBodySynDbs : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>When the value <b>true</b> is returned for the <b>SynStatus</b> parameter, the system does not return the ErrorMsg parameter.</description></item>
            /// <item><description>When the value <b>false</b> is returned for the <b>SynStatus</b> parameter, the system returns for the ErrorMsg parameter the cause why the data synchronization failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ClickHouse exception, code: 49, host: 100.100.118.132, port: 49670; Code: 49, e.displayText() = DB::Exception: Logical error: there is no global context (version 20.8.17.25)n</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-wz9d11qg1j0h4****</para>
            /// </summary>
            [NameInMap("RdsId")]
            [Validation(Required=false)]
            public string RdsId { get; set; }

            /// <summary>
            /// <para>The database account that is used to log on to the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RdsUserName")]
            [Validation(Required=false)]
            public string RdsUserName { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp16t9h3999xb0a711****.mysql.rds.aliyuncs.com:3306</para>
            /// </summary>
            [NameInMap("RdsVpcUrl")]
            [Validation(Required=false)]
            public string RdsVpcUrl { get; set; }

            /// <summary>
            /// <para>The name of the database in the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("SynDb")]
            [Validation(Required=false)]
            public string SynDb { get; set; }

            /// <summary>
            /// <para>Indicates whether the data synchronization succeeded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The data synchronization succeeded.</description></item>
            /// <item><description><b>false</b>: The data synchronization failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SynStatus")]
            [Validation(Required=false)]
            public bool? SynStatus { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
