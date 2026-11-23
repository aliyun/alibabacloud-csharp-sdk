// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class CreateThirdAppAccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>The WyId of the authorized user. The user must belong to the current calling account. This parameter is not the username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1e2d3c4b5a6****</para>
        /// </summary>
        [NameInMap("AuthorizerId")]
        [Validation(Required=false)]
        public string AuthorizerId { get; set; }

        /// <summary>
        /// <para>The business channel. Valid values: Enterprise and Business. The value is case-insensitive. If omitted, the default value is Enterprise. If an empty string or other values are explicitly passed, a parameter error is returned. This parameter does not replace user identity verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The validity period of the token, in seconds. Valid values: 1 to 15552000. If omitted, the default value is 15552000, which equals 180 days. Permanent validity is not supported, and 0 cannot be passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public int? Expiration { get; set; }

        /// <summary>
        /// <para>The target single cloud desktop resource. You must provide this object along with ResourceType and ResourceId when you call this operation. Pass this parameter as a JSON object and specify only one cloud desktop. Wildcards or authorization for all cloud desktops are not supported.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public CreateThirdAppAccessTokenRequestResource Resource { get; set; }
        public class CreateThirdAppAccessTokenRequestResource : TeaModel {
            /// <summary>
            /// <para>The ID of the target cloud desktop. You must provide a non-empty value when you call this operation. Asterisks (*) are not allowed. The cloud desktop must be authorized to the user specified by AuthorizerId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-7a8b9c0d****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. This parameter is required when you call this operation. Set the value to DESKTOP, which indicates a cloud desktop. The value is case-insensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DESKTOP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
