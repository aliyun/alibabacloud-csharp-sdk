// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTimersRequest : TeaModel {
        /// <summary>
        /// <para>The timer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The source database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db_1</para>
        /// </summary>
        [NameInMap("srcDbName")]
        [Validation(Required=false)]
        public string SrcDbName { get; set; }

        /// <summary>
        /// <para>The source table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table_1</para>
        /// </summary>
        [NameInMap("srcTableName")]
        [Validation(Required=false)]
        public string SrcTableName { get; set; }

        /// <summary>
        /// <para>Filters timers by their stopped state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stopped")]
        [Validation(Required=false)]
        public bool? Stopped { get; set; }

    }

}
