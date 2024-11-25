// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSqlStatementRequest : TeaModel {
        /// <summary>
        /// <para>The SQL code. You can specify one or more SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES</para>
        /// </summary>
        [NameInMap("codeContent")]
        [Validation(Required=false)]
        public string CodeContent { get; set; }

        /// <summary>
        /// <para>The default Data Lake Formation (DLF) catalog ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default_catalog</para>
        /// </summary>
        [NameInMap("defaultCatalog")]
        [Validation(Required=false)]
        public string DefaultCatalog { get; set; }

        /// <summary>
        /// <para>The name of the default database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The SQL session ID. You can create an SQL session in the workspace created in EMR Serverless Spark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sc-dfahdfjafhajd****</para>
        /// </summary>
        [NameInMap("sqlComputeId")]
        [Validation(Required=false)]
        public string SqlComputeId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
