// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListAliasesResponseBody : TeaModel {
        /// <summary>
        /// 别名列表
        /// </summary>
        [NameInMap("aliases")]
        [Validation(Required=false)]
        public List<ListAliasesResponseBodyAliases> Aliases { get; set; }
        public class ListAliasesResponseBodyAliases : TeaModel {
            /// <summary>
            /// 额外版本权重
            /// </summary>
            [NameInMap("additionalVersionWeight")]
            [Validation(Required=false)]
            public Dictionary<string, float?> AdditionalVersionWeight { get; set; }

            /// <summary>
            /// 别名名称
            /// </summary>
            [NameInMap("aliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 别名描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 上次更新时间
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// 版本ID
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// 下次查询token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
