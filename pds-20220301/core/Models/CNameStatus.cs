// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CNameStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BINDING/BOUND</para>
        /// </summary>
        [NameInMap("bingding_state")]
        [Validation(Required=false)]
        public string BingdingState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL/ABNORMAL</para>
        /// </summary>
        [NameInMap("legal_state")]
        [Validation(Required=false)]
        public string LegalState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>beian</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
