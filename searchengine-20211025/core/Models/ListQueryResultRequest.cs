// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListQueryResultRequest : TeaModel {
        /// <summary>
        /// <para>The query statement</para>
        /// 
        /// <b>Example:</b>
        /// <para>query%3D1%26%26config%3Dstart%3A0%2Chit%3A10%2Cformat%3Ajson%26%26cluster%3Dgeneral</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The SQL statement that is executed in the query</para>
        /// 
        /// <b>Example:</b>
        /// <para>query%3Dselect%20max(content_id)%20from%20generation</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
