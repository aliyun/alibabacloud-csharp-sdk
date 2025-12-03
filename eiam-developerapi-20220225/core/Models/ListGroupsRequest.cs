// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_xxx</para>
        /// </summary>
        [NameInMap("groupNameStartWith")]
        [Validation(Required=false)]
        public string GroupNameStartWith { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>nextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
