// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListVectorQueryResultRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The query type. Valid values: vector, primary_key, and vector_text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary_key</para>
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The vector query type. Valid values: vector, image, and text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("vectorQueryType")]
        [Validation(Required=false)]
        public string VectorQueryType { get; set; }

    }

}
