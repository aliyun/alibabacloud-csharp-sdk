// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeCostOptimizationOverviewShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11***********35</para>
        /// </summary>
        [NameInMap("AssumeAliyunId")]
        [Validation(Required=false)]
        public long? AssumeAliyunId { get; set; }

        [NameInMap("AssumeAliyunIdList")]
        [Validation(Required=false)]
        public string AssumeAliyunIdListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
