// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetUserResourceStatusResponseBody : TeaModel {
        /// <summary>
        /// 现金账户余额
        /// </summary>
        [NameInMap("AccountBalance")]
        [Validation(Required=false)]
        public float? AccountBalance { get; set; }

        /// <summary>
        /// 金额是否充足
        /// </summary>
        [NameInMap("AccountSufficient")]
        [Validation(Required=false)]
        public bool? AccountSufficient { get; set; }

        /// <summary>
        /// 充值页面
        /// </summary>
        [NameInMap("AccountTopUpPage")]
        [Validation(Required=false)]
        public string AccountTopUpPage { get; set; }

        /// <summary>
        /// 授权页面
        /// </summary>
        [NameInMap("AllAuthorizationPage")]
        [Validation(Required=false)]
        public string AllAuthorizationPage { get; set; }

        /// <summary>
        /// 代金券余额
        /// </summary>
        [NameInMap("CouponBalance")]
        [Validation(Required=false)]
        public float? CouponBalance { get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// 是否通过购买条件验证
        /// </summary>
        [NameInMap("HasAllAuthorization")]
        [Validation(Required=false)]
        public bool? HasAllAuthorization { get; set; }

        /// <summary>
        /// 是否国际站账号
        /// </summary>
        [NameInMap("International")]
        [Validation(Required=false)]
        public bool? International { get; set; }

        /// <summary>
        /// 是否实名验证
        /// </summary>
        [NameInMap("RealNameVerified")]
        [Validation(Required=false)]
        public bool? RealNameVerified { get; set; }

        /// <summary>
        /// 实名验证页面
        /// </summary>
        [NameInMap("RealNameVerifiedPage")]
        [Validation(Required=false)]
        public string RealNameVerifiedPage { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总余额
        /// </summary>
        [NameInMap("TotalBalance")]
        [Validation(Required=false)]
        public float? TotalBalance { get; set; }

    }

}
