// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceLabelRequest : TeaModel {
        /// <summary>
        /// <para>The custom service tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

    }

}
