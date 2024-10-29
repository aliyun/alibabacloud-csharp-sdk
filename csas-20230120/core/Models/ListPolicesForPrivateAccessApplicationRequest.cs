// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForPrivateAccessApplicationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

    }

}
