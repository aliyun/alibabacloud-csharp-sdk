// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Node : TeaModel {
        /// <summary>
        /// <para>The name of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon</para>
        /// </summary>
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The name of the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon</para>
        /// </summary>
        [NameInMap("connector")]
        [Validation(Required=false)]
        public string Connector { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon-ods</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97383</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether the table is a temporary table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isTemporary")]
        [Validation(Required=false)]
        public bool? IsTemporary { get; set; }

        /// <summary>
        /// <para>The information about the table.</para>
        /// </summary>
        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<LineageTable> Tables { get; set; }

    }

}
