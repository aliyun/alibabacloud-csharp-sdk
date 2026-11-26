// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingChannelDistribution : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ArticleCount")]
        [Validation(Required=false)]
        public long? ArticleCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEBSITE</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

    }

}
