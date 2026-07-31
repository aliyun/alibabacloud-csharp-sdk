// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvBaseTableDetailModel : TeaModel {
        /// <summary>
        /// <para>The data volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>321233</para>
        /// </summary>
        [NameInMap("DataVolumn")]
        [Validation(Required=false)]
        public string DataVolumn { get; set; }

        /// <summary>
        /// <para>Indicates whether binary logging is enabled for the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBinlog")]
        [Validation(Required=false)]
        public bool? EnableBinlog { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
