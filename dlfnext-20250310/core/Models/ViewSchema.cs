// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ViewSchema : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Queries for different engines.</para>
        /// </summary>
        [NameInMap("dialects")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dialects { get; set; }

        /// <summary>
        /// <para>The list of field definitions for the view.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DataField> Fields { get; set; }

        /// <summary>
        /// <para>The configuration parameters for the view.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The default query for the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select id from t1;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
