// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class ModelTypeDetermineShrinkRequest : TeaModel {
        [NameInMap("history")]
        [Validation(Required=false)]
        public string HistoryShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputText")]
        [Validation(Required=false)]
        public string InputText { get; set; }

    }

}
