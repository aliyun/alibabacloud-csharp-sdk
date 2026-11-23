// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetStsTokenRequest : TeaModel {
        /// <summary>
        /// <para>The Wuying username.</para>
        /// <remarks>
        /// <para>Either the Wuying username or the external ID is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alex</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The expiration time in seconds. The maximum validity period is two days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        /// <summary>
        /// <para>The external user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alex</para>
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

    }

}
