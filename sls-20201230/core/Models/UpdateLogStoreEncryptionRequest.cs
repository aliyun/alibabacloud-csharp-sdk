// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreEncryptionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("encryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        [NameInMap("userCmkInfo")]
        [Validation(Required=false)]
        public UpdateLogStoreEncryptionRequestUserCmkInfo UserCmkInfo { get; set; }
        public class UpdateLogStoreEncryptionRequestUserCmkInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>f5136b95-2420-ab31-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("keyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::12344***:role/xxxxx</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

    }

}
