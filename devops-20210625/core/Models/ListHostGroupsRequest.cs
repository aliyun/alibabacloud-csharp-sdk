// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListHostGroupsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1586863220000</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1586863220000</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1112122121,3223332</para>
        /// </summary>
        [NameInMap("creatorAccountIds")]
        [Validation(Required=false)]
        public string CreatorAccountIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>121,1212121232</para>
        /// </summary>
        [NameInMap("ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>主机组</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>221212221</para>
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
