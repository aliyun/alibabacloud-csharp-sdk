// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductCategory : TeaModel {
        /// <summary>
        /// <para>The unique category ID.</para>
        /// </summary>
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The category description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The category icon.</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public HiMarketIcon Icon { get; set; }

        /// <summary>
        /// <para>The category name.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
