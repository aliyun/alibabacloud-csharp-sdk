// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>User Information</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public UpdateUserRequestUser User { get; set; }
        public class UpdateUserRequestUser : TeaModel {
            /// <summary>
            /// <para>Whether EventBridge is enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableEventbridge")]
            [Validation(Required=false)]
            public bool? EnableEventbridge { get; set; }

        }

    }

}
