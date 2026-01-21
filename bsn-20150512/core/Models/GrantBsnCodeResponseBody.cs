// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class GrantBsnCodeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>456*******163</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>124*******345</para>
        /// </summary>
        [NameInMap("GrantToAliuid")]
        [Validation(Required=false)]
        public long? GrantToAliuid { get; set; }

        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FA30A2AF-9542-5927-9B73-2030F1A68DBF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1131-*******-233</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
