// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsTablesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database that contains the source tables to be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The destination MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pj</para>
        /// </summary>
        [NameInMap("dstProjectName")]
        [Validation(Required=false)]
        public string DstProjectName { get; set; }

        /// <summary>
        /// <para>The destination MaxCompute schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dstSchemaName")]
        [Validation(Required=false)]
        public string DstSchemaName { get; set; }

        /// <summary>
        /// <para>The migration status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of source tables to be updated.</para>
        /// </summary>
        [NameInMap("tableNames")]
        [Validation(Required=false)]
        public List<string> TableNames { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<long?> Tables { get; set; }

    }

}
