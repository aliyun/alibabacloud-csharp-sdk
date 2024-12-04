// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckCloudResourceAuthorizedResponseBodyData Data { get; set; }
        public class CheckCloudResourceAuthorizedResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuthorizationState")]
            [Validation(Required=false)]
            public string AuthorizationState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/AliyunRdsInstanceEncryptionDefaultRole</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
