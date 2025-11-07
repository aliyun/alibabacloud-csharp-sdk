// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyCustomizeFlowStrategyListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Product type, currently only supports <b>ANT_CLOUD_AUTH</b> (Financial-grade real person), all others have been phased out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_CLOUD_AUTH</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Strategy list.</para>
        /// </summary>
        [NameInMap("StrategyObject")]
        [Validation(Required=false)]
        public string StrategyObjectShrink { get; set; }

    }

}
