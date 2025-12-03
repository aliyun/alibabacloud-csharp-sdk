// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListUserGroupsMappingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroupsMappings")]
        [Validation(Required=false)]
        public List<ListUserGroupsMappingsResponseBodyUserGroupsMappings> UserGroupsMappings { get; set; }
        public class ListUserGroupsMappingsResponseBodyUserGroupsMappings : TeaModel {
            [NameInMap("GroupNames")]
            [Validation(Required=false)]
            public List<string> GroupNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
