// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceLabelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The service tags that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string KeysShrink { get; set; }

    }

}
