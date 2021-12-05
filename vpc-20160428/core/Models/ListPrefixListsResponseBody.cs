// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPrefixListsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListPrefixListsResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListPrefixListsResponseBodyPrefixLists : TeaModel {
            /// <summary>
            /// 前缀列表包含的网段
            /// </summary>
            [NameInMap("CidrBlocks")]
            [Validation(Required=false)]
            public List<string> CidrBlocks { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// IpVersion
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("PrefixListDescription")]
            [Validation(Required=false)]
            public string PrefixListDescription { get; set; }

            /// <summary>
            /// 前缀列表的实例ID
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("PrefixListName")]
            [Validation(Required=false)]
            public string PrefixListName { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("PrefixListStatus")]
            [Validation(Required=false)]
            public string PrefixListStatus { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
