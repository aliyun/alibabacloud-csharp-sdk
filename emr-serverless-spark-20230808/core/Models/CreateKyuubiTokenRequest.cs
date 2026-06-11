// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateKyuubiTokenRequest : TeaModel {
        /// <summary>
        /// <para>The automatic expiration settings.</para>
        /// </summary>
        [NameInMap("autoExpireConfiguration")]
        [Validation(Required=false)]
        public CreateKyuubiTokenRequestAutoExpireConfiguration AutoExpireConfiguration { get; set; }
        public class CreateKyuubiTokenRequestAutoExpireConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether the token automatically expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The expiration period in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365</para>
            /// </summary>
            [NameInMap("expireDays")]
            [Validation(Required=false)]
            public int? ExpireDays { get; set; }

        }

        /// <summary>
        /// <para>The list of ARNs of authorized users.</para>
        /// </summary>
        [NameInMap("memberArns")]
        [Validation(Required=false)]
        public List<string> MemberArns { get; set; }

        /// <summary>
        /// <para>The token name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_serverless_spark</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("sparkRole")]
        [Validation(Required=false)]
        public List<string> SparkRole { get; set; }

        /// <summary>
        /// <para>The token content. The token must be 32 characters long and contain only lowercase letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rjy7ejhej9gkzjjuun49jnx2xk8if2cu</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
