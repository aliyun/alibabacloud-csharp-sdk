// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class BroadcastAudio : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("audioLength")]
        [Validation(Required=false)]
        public int? AudioLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-22T01:59:03</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M1Ju6XhHog_e-lSeb80Slp9g</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-22T01:59:03</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
