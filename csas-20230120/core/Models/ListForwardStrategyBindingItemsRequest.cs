// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListForwardStrategyBindingItemsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ForwardIds")]
        [Validation(Required=false)]
        public List<string> ForwardIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ItemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

    }

}
