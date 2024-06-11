// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateLoginProfileResponseBody : TeaModel {
        /// <summary>
        /// The logon configurations of the RAM user.
        /// </summary>
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public CreateLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class CreateLoginProfileResponseBodyLoginProfile : TeaModel {
            /// <summary>
            /// The time when the logon configurations were created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// Indicates whether an MFA device must be attached to the RAM user upon logon.
            /// </summary>
            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            /// <summary>
            /// Indicates whether the RAM user must change the password upon logon.
            /// </summary>
            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            /// <summary>
            /// The name of the RAM user.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
