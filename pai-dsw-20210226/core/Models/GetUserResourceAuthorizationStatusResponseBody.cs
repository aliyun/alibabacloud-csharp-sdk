// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetUserResourceAuthorizationStatusResponseBody : TeaModel {
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
        /// 授权开通页面
        /// </summary>
        [NameInMap("AllAuthorizationPage")]
        [Validation(Required=false)]
        public string AllAuthorizationPage { get; set; }

        /// <summary>
        /// 购买页
        /// </summary>
        [NameInMap("BuyPage")]
        [Validation(Required=false)]
        public string BuyPage { get; set; }

        /// <summary>
        /// 代金券金额
        /// </summary>
        [NameInMap("CouponBalance")]
        [Validation(Required=false)]
        public float? CouponBalance { get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        [NameInMap("CurrentFeatureVersion")]
        [Validation(Required=false)]
        public string CurrentFeatureVersion { get; set; }

        /// <summary>
        /// 是否禁止金额验证
        /// </summary>
        [NameInMap("DisableBalanceCheck")]
        [Validation(Required=false)]
        public bool? DisableBalanceCheck { get; set; }

        /// <summary>
        /// dsw默认角色授权页面
        /// </summary>
        [NameInMap("DswDefaultAuthorizationPage")]
        [Validation(Required=false)]
        public string DswDefaultAuthorizationPage { get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// ess开通页面
        /// </summary>
        [NameInMap("EssConsolePage")]
        [Validation(Required=false)]
        public string EssConsolePage { get; set; }

        /// <summary>
        /// ess是否开通
        /// </summary>
        [NameInMap("EssServiceAvailable")]
        [Validation(Required=false)]
        public bool? EssServiceAvailable { get; set; }

        /// <summary>
        /// 是否通过购买验证
        /// </summary>
        [NameInMap("HasAllAuthorization")]
        [Validation(Required=false)]
        public bool? HasAllAuthorization { get; set; }

        /// <summary>
        /// 是否通过授权验证
        /// </summary>
        [NameInMap("HasDswDefaultAuthorization")]
        [Validation(Required=false)]
        public bool? HasDswDefaultAuthorization { get; set; }

        /// <summary>
        /// 是否国际站账号
        /// </summary>
        [NameInMap("International")]
        [Validation(Required=false)]
        public bool? International { get; set; }

        /// <summary>
        /// 是否子账号登录
        /// </summary>
        [NameInMap("IsSubUser")]
        [Validation(Required=false)]
        public bool? IsSubUser { get; set; }

        /// <summary>
        /// nas控制台
        /// </summary>
        [NameInMap("NasConsolePage")]
        [Validation(Required=false)]
        public string NasConsolePage { get; set; }

        /// <summary>
        /// 是否实名认证
        /// </summary>
        [NameInMap("RealNameVerified")]
        [Validation(Required=false)]
        public bool? RealNameVerified { get; set; }

        /// <summary>
        /// 实名认证页面
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
        /// 子账号授权开通页面
        /// </summary>
        [NameInMap("SubUserAuthorizationPage")]
        [Validation(Required=false)]
        public string SubUserAuthorizationPage { get; set; }

        /// <summary>
        /// 子账号是否授权通过
        /// </summary>
        [NameInMap("SubUserAuthorized")]
        [Validation(Required=false)]
        public bool? SubUserAuthorized { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [NameInMap("TotalBalance")]
        [Validation(Required=false)]
        public float? TotalBalance { get; set; }

    }

}
