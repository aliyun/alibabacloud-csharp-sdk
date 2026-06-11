// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSqlStatementRequest : TeaModel {
        /// <summary>
        /// <para>The SQL code. This parameter accepts one or more SQL statements for execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES</para>
        /// </summary>
        [NameInMap("codeContent")]
        [Validation(Required=false)]
        public string CodeContent { get; set; }

        /// <summary>
        /// <para>The ID of the default DLF Catalog.</para>
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
        /// <para>The limit value. The value must be between 1 and 10000, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The ID of the SQL session. The session must be created in the Session Manager module of the EMR Serverless Spark workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sc-dfahdfjafhajd****</para>
        /// </summary>
        [NameInMap("sqlComputeId")]
        [Validation(Required=false)]
        public string SqlComputeId { get; set; }

        [NameInMap("taskBizId")]
        [Validation(Required=false)]
        public string TaskBizId { get; set; }

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
