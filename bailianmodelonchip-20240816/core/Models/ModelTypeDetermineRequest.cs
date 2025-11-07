// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class ModelTypeDetermineRequest : TeaModel {
        [NameInMap("history")]
        [Validation(Required=false)]
        public List<ModelTypeDetermineRequestHistory> History { get; set; }
        public class ModelTypeDetermineRequestHistory : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputText")]
        [Validation(Required=false)]
        public string InputText { get; set; }

    }

}
