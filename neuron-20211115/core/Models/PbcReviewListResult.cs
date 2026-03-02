// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcReviewListResult : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PbcReview> Data { get; set; }

        /// <summary>
        /// <para>总数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
