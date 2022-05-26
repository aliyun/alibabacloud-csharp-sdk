// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEnrolledAccountsResponseBody : TeaModel {
        /// <summary>
        /// 账号列表
        /// </summary>
        [NameInMap("EnrolledAccounts")]
        [Validation(Required=false)]
        public List<ListEnrolledAccountsResponseBodyEnrolledAccounts> EnrolledAccounts { get; set; }
        public class ListEnrolledAccountsResponseBodyEnrolledAccounts : TeaModel {
            /// <summary>
            /// 账号ID
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 账号显示名称
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 父资源夹ID
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// 结算账号ID
            /// </summary>
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }

            /// <summary>
            /// 创建状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// 查询返回结果下一页的令牌
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
