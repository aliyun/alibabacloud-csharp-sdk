// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SyncAppInstanceForPartnerShrinkRequest : TeaModel {
        [NameInMap("AppInstance")]
        [Validation(Required=false)]
        public string AppInstanceShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31104757</para>
        /// </summary>
        [NameInMap("SourceBizId")]
        [Validation(Required=false)]
        public string SourceBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MARKET_CLOUD_DREAM</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
