// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class GrantBsnCodeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>456*******163</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1131-*******-233</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
