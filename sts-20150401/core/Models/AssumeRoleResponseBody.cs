// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary identity that you use to assume the RAM role.</para>
        /// </summary>
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleResponseBodyAssumedRoleUser : TeaModel {
            /// <summary>
            /// <para>The ARN of the temporary identity that you use to assume the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/adminrole/alice</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The ID of the temporary identity that you use to assume the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34458433936495****:alice</para>
            /// </summary>
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        /// <summary>
        /// <para>The STS credentials.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.L4aBSCSJVMuKg5U1****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wyLTSmsyPGP1ohvvw8xYgB29dlGI8KMiH2pK****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The time when the STS token expires. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-04-09T11:52:19Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The STS token.</para>
            /// <remarks>
            /// <para>Alibaba Cloud STS does not impose limits on the length of STS tokens. We strongly recommend that you do not specify a maximum length for STS tokens.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6894B13B-6D71-4EF5-88FA-F32781734A7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
