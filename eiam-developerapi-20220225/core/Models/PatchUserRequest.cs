// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class PatchUserRequest : TeaModel {
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public List<PatchUserRequestCustomFields> CustomFields { get; set; }
        public class PatchUserRequestCustomFields : TeaModel {
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// 字段操作类型，取值可选范围：
            /// - add：添加。
            /// - replace：替换。若对应扩展字段无设置值，会转换为add操作。
            /// - remove：移除。
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            [Obsolete]
            public string Operator { get; set; }

        }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
