// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetMetaCompareIncrementDbOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The name of the catalog. In a multi-catalog environment, it is used to locate the catalog where the destination database resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fluss_e2e_dlf_catalog</para>
        /// </summary>
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The name of the database for which you want to query incremental changes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_eaps</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only summary statistics.</para>
        /// </summary>
        [NameInMap("isSummary")]
        [Validation(Required=false)]
        public bool? IsSummary { get; set; }

        /// <summary>
        /// <para>The ID of the metadata comparison task, which is obtained from the return value of the create or save comparison task API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
