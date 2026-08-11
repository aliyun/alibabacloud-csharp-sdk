// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListIndexesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data catalog for the Data Lake Formation (DLF) data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-paimon-765e9e2d43ab4fccbf095853a661eafc</para>
        /// </summary>
        [NameInMap("catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The database of the DLF data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf_test</para>
        /// </summary>
        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the new version of the console page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

        /// <summary>
        /// <para>The data table of the DLF data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
