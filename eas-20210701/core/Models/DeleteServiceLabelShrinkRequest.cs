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
        /// <para>The keys of the service labels that you want to delete. This parameter is deprecated. Use the LabelKeys parameter instead.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        [Obsolete]
        public string KeysShrink { get; set; }

        /// <summary>
        /// <para>The keys of the service labels that you want to delete.</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeysShrink { get; set; }

    }

}
