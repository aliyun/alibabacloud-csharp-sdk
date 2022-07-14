// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainResponseBody : TeaModel {
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDomainResponseBodyDomainList> DomainList { get; set; }
        public class DescribeOutgoingDomainResponseBodyDomainList : TeaModel {
            /// <summary>
            /// ACL覆盖
            /// </summary>
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            /// <summary>
            /// ACL推荐内容
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// ACL状态
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// 地址簿名称
            /// </summary>
            [NameInMap("AddressGroupName")]
            [Validation(Required=false)]
            public string AddressGroupName { get; set; }

            /// <summary>
            /// 地址簿UUID
            /// </summary>
            [NameInMap("AddressGroupUUID")]
            [Validation(Required=false)]
            public string AddressGroupUUID { get; set; }

            /// <summary>
            /// 分类ID
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// 分类名称
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// 域名
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// 规则中的组名称
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 是否有ACL推荐规则
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// 入流量
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// 是否正常
            /// </summary>
            [NameInMap("IsMarkNormal")]
            [Validation(Required=false)]
            public bool? IsMarkNormal { get; set; }

            /// <summary>
            /// 出流量
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// ACL规则ID
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// 规则名称
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// 安全建议
            /// </summary>
            [NameInMap("SecuritySuggest")]
            [Validation(Required=false)]
            public string SecuritySuggest { get; set; }

            /// <summary>
            /// 会话数
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDomainResponseBodyDomainListTagList> TagList { get; set; }
            public class DescribeOutgoingDomainResponseBodyDomainListTagList : TeaModel {
                /// <summary>
                /// 风险等级
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// 标签描述
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// 标签ID
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// 标签名称
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
