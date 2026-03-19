// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ColumnKnowledgeInfo : TeaModel {
        /// <summary>
        /// <para>User-edited business knowledge content, which can be modified via the EditMetaKnowledgeAsset API.</para>
        /// </summary>
        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        /// <summary>
        /// <para>The last modified time of the field.</para>
        /// </summary>
        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        /// <summary>
        /// <para>The name of the field.</para>
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// <para>The data type of the field.</para>
        /// </summary>
        [NameInMap("ColumnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

        /// <summary>
        /// <para>Field description in the CREATE TABLE statement.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The field order in the CREATE TABLE statement.</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

    }

}
