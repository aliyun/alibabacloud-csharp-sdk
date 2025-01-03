// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListVariableGroupsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aaaaaa</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("pageOrder")]
        [Validation(Required=false)]
        public string PageOrder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ID</para>
        /// </summary>
        [NameInMap("pageSort")]
        [Validation(Required=false)]
        public string PageSort { get; set; }

    }

}
