// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the sharing link. Default value: 604800 seconds. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the job to be shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc*******</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the shared job. Valid values: job and tensorboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The permission settings of the sharing token, which controls log download and cross-account access.</para>
        /// </summary>
        [NameInMap("TokenSettings")]
        [Validation(Required=false)]
        public TokenSettings TokenSettings { get; set; }

    }

}
