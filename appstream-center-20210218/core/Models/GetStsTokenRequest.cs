// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetStsTokenRequest : TeaModel {
        /// <summary>
        /// <para>The Elastic Desktop Service (EDS) username.</para>
        /// <remarks>
        /// <para>Either EndUserId or ExternalId is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alex</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The validity period of the token, in seconds. The maximum period is two days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        /// <summary>
        /// <para>The ID of the external user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alex</para>
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

    }

}
