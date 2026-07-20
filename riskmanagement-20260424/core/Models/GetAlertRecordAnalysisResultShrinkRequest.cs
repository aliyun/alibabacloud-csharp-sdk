// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>9b57f0fcf98181df8d8487d1cc91cb8d</para>
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fc312aa0c32ba8a6147db6221fb1c1ee</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        [NameInMap("UniqueTagList")]
        [Validation(Required=false)]
        public string UniqueTagListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ebde6d4e3e4aba728962eec43a69196e9J7tt7H47Pc</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
