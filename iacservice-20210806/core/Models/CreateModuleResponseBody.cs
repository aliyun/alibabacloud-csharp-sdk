// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateModuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mod-518855d9a058cfffcc446d8fe3c99</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0D797DC3-FF04-5C21-81EB-92C7799512E3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
