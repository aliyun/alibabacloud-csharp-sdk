// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class RefreshLivyComputeTokenRequest : TeaModel {
        /// <summary>
        /// <para>The token expiration information struct.</para>
        /// </summary>
        [NameInMap("autoExpireConfiguration")]
        [Validation(Required=false)]
        public RefreshLivyComputeTokenRequestAutoExpireConfiguration AutoExpireConfiguration { get; set; }
        public class RefreshLivyComputeTokenRequestAutoExpireConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether the token automatically expires. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The expiration time in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("expireDays")]
            [Validation(Required=false)]
            public int? ExpireDays { get; set; }

        }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The token content. The length must be at least 16.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe86812667f04v343</para>
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
