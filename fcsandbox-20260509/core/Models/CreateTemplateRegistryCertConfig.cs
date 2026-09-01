// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateRegistryCertConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip certificate verification.</para>
        /// </summary>
        [NameInMap("insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

    }

}
