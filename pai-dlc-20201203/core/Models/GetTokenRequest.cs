// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the sharing link in seconds. Default value: 604800. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the task to share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc*******</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task to share. Valid values: job and tensorboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("TokenSettings")]
        [Validation(Required=false)]
        public TokenSettings TokenSettings { get; set; }

    }

}
