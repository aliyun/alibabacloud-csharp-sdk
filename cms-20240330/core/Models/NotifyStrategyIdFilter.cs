// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyIdFilter : TeaModel {
        /// <summary>
        /// <para>The exact ID of the notification strategy to retrieve.</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public string Eq { get; set; }

    }

}
