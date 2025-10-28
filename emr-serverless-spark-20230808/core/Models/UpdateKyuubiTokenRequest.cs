// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateKyuubiTokenRequest : TeaModel {
        [NameInMap("autoExpireConfiguration")]
        [Validation(Required=false)]
        public UpdateKyuubiTokenRequestAutoExpireConfiguration AutoExpireConfiguration { get; set; }
        public class UpdateKyuubiTokenRequestAutoExpireConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>365</para>
            /// </summary>
            [NameInMap("expireDays")]
            [Validation(Required=false)]
            public int? ExpireDays { get; set; }

        }

        [NameInMap("memberArns")]
        [Validation(Required=false)]
        public List<string> MemberArns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev_serverless_spark</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rjy7ejhej9gkzjjuun49jnx2xk8if2cu</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
