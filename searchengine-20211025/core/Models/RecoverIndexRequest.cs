// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class RecoverIndexRequest : TeaModel {
        /// <summary>
        /// <para>The deployment ID of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>277</para>
        /// </summary>
        [NameInMap("buildDeployId")]
        [Validation(Required=false)]
        public int? BuildDeployId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0js04_odps_first</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The ID of the full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653018575</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public string Generation { get; set; }

        /// <summary>
        /// <para>The index name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main_index</para>
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

    }

}
