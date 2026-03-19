// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class TableKnowledgeInfo : TeaModel {
        /// <summary>
        /// <para>Table usage instructions, which are not editable in OpenAPI.</para>
        /// </summary>
        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        /// <summary>
        /// <para>Last modified time.</para>
        /// </summary>
        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        /// <summary>
        /// <para>The columns of the table.</para>
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public List<ColumnKnowledgeInfo> ColumnList { get; set; }

        /// <summary>
        /// <para>Table description in the CREAT TABLE statement.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Table business description, which can be edited via EditMetaKnowledgeAsset.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
