// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceLabelShrinkRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The service tags that you want to delete.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeysShrink { get; set; }

        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeysShrink { get; set; }

    }

}
