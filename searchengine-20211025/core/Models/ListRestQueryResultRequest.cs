// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListRestQueryResultRequest : TeaModel {
        /// <summary>
        /// <para>The name of the index table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main_index</para>
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// <para>The rest query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query%3Drelation_id%3A%221151274675_2%22%26%26cluster%3Dgeneral%26%26config%3Dstart%3A0%2Chit%3A10%2Cformat%3Ajson</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public Dictionary<string, object> Query { get; set; }

    }

}
