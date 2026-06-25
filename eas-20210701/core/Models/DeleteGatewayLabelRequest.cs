// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteGatewayLabelRequest : TeaModel {
        /// <summary>
        /// <para>The keys of the labels that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public List<string> LabelKeys { get; set; }

    }

}
