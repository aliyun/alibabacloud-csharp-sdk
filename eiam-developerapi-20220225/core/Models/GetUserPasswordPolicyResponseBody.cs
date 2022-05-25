// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetUserPasswordPolicyResponseBody : TeaModel {
        /// <summary>
        /// 密码修改周期, 单位毫秒，-1表示永不过期
        /// </summary>
        [NameInMap("activeCycle")]
        [Validation(Required=false)]
        public long? ActiveCycle { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 密码最短长度，-1表示不限制
        /// </summary>
        [NameInMap("minLength")]
        [Validation(Required=false)]
        public int? MinLength { get; set; }

        /// <summary>
        /// 密码复杂项
        /// </summary>
        [NameInMap("passwordComplexityItem")]
        [Validation(Required=false)]
        public GetUserPasswordPolicyResponseBodyPasswordComplexityItem PasswordComplexityItem { get; set; }
        public class GetUserPasswordPolicyResponseBodyPasswordComplexityItem : TeaModel {
            [NameInMap("containLowerCase")]
            [Validation(Required=false)]
            public bool? ContainLowerCase { get; set; }
            [NameInMap("containNumber")]
            [Validation(Required=false)]
            public bool? ContainNumber { get; set; }
            [NameInMap("containSpecialChar")]
            [Validation(Required=false)]
            public bool? ContainSpecialChar { get; set; }
            [NameInMap("containUpperCase")]
            [Validation(Required=false)]
            public bool? ContainUpperCase { get; set; }
            [NameInMap("displayNameCheck")]
            [Validation(Required=false)]
            public bool? DisplayNameCheck { get; set; }
            [NameInMap("emailCheck")]
            [Validation(Required=false)]
            public bool? EmailCheck { get; set; }
            [NameInMap("phoneCheck")]
            [Validation(Required=false)]
            public bool? PhoneCheck { get; set; }
            [NameInMap("usernameCheck")]
            [Validation(Required=false)]
            public bool? UsernameCheck { get; set; }
        };

        /// <summary>
        /// 保留最近密码记录数
        /// </summary>
        [NameInMap("reservationCount")]
        [Validation(Required=false)]
        public int? ReservationCount { get; set; }

    }

}
