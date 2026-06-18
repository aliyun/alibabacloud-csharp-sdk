// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckCloudResourceAuthorizedResponseBodyData Data { get; set; }
        public class CheckCloudResourceAuthorizedResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authorization status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not authorized.</description></item>
            /// <item><description><b>1</b>: authorized.</description></item>
            /// <item><description><b>2</b>: KMS is not activated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuthorizationState")]
            [Validation(Required=false)]
            public string AuthorizationState { get; set; }

            /// <summary>
            /// <para>The global resource descriptor ARN (Alibaba Cloud Resource Name) of the authorized role. After the authorization of this role is complete, the related KMS can be used. Format: acs:ram::$accountID:role/$roleName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/AliyunRdsInstanceEncryptionDefaultRole</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
