// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateSystemPropertyTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAuto")]
        [Validation(Required=false)]
        public bool? EnableAuto { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://filepath****.com">https://filepath****.com</a></para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("SystemPropertyInfo")]
        [Validation(Required=false)]
        public string SystemPropertyInfoShrink { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
