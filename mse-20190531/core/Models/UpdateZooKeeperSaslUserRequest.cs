// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateZooKeeperSaslUserRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-tl327w****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the changes take effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reload")]
        [Validation(Required=false)]
        public bool? Reload { get; set; }

        /// <summary>
        /// <para>The list of SASL users to update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SaslUser")]
        [Validation(Required=false)]
        public List<UpdateZooKeeperSaslUserRequestSaslUser> SaslUser { get; set; }
        public class UpdateZooKeeperSaslUserRequestSaslUser : TeaModel {
            /// <summary>
            /// <para>The description of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The original password. This parameter is required if you want to change the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin-password</para>
            /// </summary>
            [NameInMap("OriginPassword")]
            [Validation(Required=false)]
            public string OriginPassword { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
