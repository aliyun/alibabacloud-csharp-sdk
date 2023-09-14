// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupServersRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return. Valid values: **1** to **100**. If you do not specify a value, the default value **20** is used.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of **NextToken**.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The server group ID.
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// The IDs of the servers.
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// The tags that are added to the server group. You can specify up to 10 tags in each call.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServerGroupServersRequestTag> Tag { get; set; }
        public class ListServerGroupServersRequestTag : TeaModel {
            /// <summary>
            /// The tag key. You can specify up to 10 tag keys.
            /// 
            /// The tag key can be up to 64 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify up to 10 tag values.
            /// 
            /// The tag value can be up to 128 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
