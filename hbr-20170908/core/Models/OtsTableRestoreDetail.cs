// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class OtsTableRestoreDetail : TeaModel {
        /// <summary>
        /// <para>The number of concurrent processes for each restore job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BatchChannelCount")]
        [Validation(Required=false)]
        public int? BatchChannelCount { get; set; }

        /// <summary>
        /// <para>The name prefixes of the indexes that you want to restore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022xxxx143933</para>
        /// </summary>
        [NameInMap("IndexNameSuffix")]
        [Validation(Required=false)]
        public string IndexNameSuffix { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite existing tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OverwriteExisting")]
        [Validation(Required=false)]
        public bool? OverwriteExisting { get; set; }

        /// <summary>
        /// <para>Specifies whether to regenerate auto-increment primary keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReGenerateAutoIncrementPK")]
        [Validation(Required=false)]
        public bool? ReGenerateAutoIncrementPK { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RestoreIndex")]
        [Validation(Required=false)]
        public bool? RestoreIndex { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore search indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RestoreSearchIndex")]
        [Validation(Required=false)]
        public bool? RestoreSearchIndex { get; set; }

        /// <summary>
        /// <para>The name prefixes of the search indexes that you want to restore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022xxxx143933</para>
        /// </summary>
        [NameInMap("SearchIndexNameSuffix")]
        [Validation(Required=false)]
        public string SearchIndexNameSuffix { get; set; }

    }

}
