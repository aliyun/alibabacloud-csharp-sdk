// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListPbcInvokesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>223352752411587433</para>
        /// </summary>
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

    }

}
