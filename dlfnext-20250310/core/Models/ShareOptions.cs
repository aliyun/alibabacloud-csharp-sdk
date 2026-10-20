// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ShareOptions : TeaModel {
        /// <summary>
        /// <para>The maximum number of catalogs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("catalogSizeLimit")]
        [Validation(Required=false)]
        public int? CatalogSizeLimit { get; set; }

        /// <summary>
        /// <para>The maximum number of recipients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("receiverSizeLimit")]
        [Validation(Required=false)]
        public int? ReceiverSizeLimit { get; set; }

        /// <summary>
        /// <para>The maximum shared resource count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("shareResourceSizeLimit")]
        [Validation(Required=false)]
        public int? ShareResourceSizeLimit { get; set; }

        /// <summary>
        /// <para>The maximum number of shares.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("shareSizeLimit")]
        [Validation(Required=false)]
        public int? ShareSizeLimit { get; set; }

    }

}
