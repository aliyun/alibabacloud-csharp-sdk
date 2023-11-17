// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGatewayResponseBody : TeaModel {
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// 网关创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExternalClusterId")]
        [Validation(Required=false)]
        public string ExternalClusterId { get; set; }

        /// <summary>
        /// 网关ID
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

        /// <summary>
        /// 网关创建的实例种类
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InternetAclPolicyList")]
        [Validation(Required=false)]
        public List<DescribeGatewayResponseBodyInternetAclPolicyList> InternetAclPolicyList { get; set; }
        public class DescribeGatewayResponseBodyInternetAclPolicyList : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 网关内部域名
        /// </summary>
        [NameInMap("InternetDomain")]
        [Validation(Required=false)]
        public string InternetDomain { get; set; }

        [NameInMap("InternetEnabled")]
        [Validation(Required=false)]
        public bool? InternetEnabled { get; set; }

        /// <summary>
        /// 网关外部域名
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        [NameInMap("IntranetEnabled")]
        [Validation(Required=false)]
        public bool? IntranetEnabled { get; set; }

        [NameInMap("IntranetLinkedVpcList")]
        [Validation(Required=false)]
        public List<DescribeGatewayResponseBodyIntranetLinkedVpcList> IntranetLinkedVpcList { get; set; }
        public class DescribeGatewayResponseBodyIntranetLinkedVpcList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// 创建网关的用户ID
        /// </summary>
        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        /// <summary>
        /// 网关所在地域
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 网关现在的状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 网关最后一次的更新时间
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
