// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteCostRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of model API IDs affected by the deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ma-2ze3x6i1d7g5rto28&quot;]</para>
        /// </summary>
        [NameInMap("AffectedModelApiIds")]
        [Validation(Required=false)]
        public List<string> AffectedModelApiIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E2FE3BB-C677-5FF9-9FC5-9CF364BD6BE5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the deletion was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
