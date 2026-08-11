// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListPostQueryResultRequest : TeaModel {
        /// <summary>
        /// <para>The request structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;assemblyQuery&quot;:&quot;query=id:1&amp;&amp;cluster=general&amp;&amp;config=start:0,hit:10,format:json&quot;}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

        /// <summary>
        /// <para>sql: SQL query. ha3: HA3 query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha3</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
