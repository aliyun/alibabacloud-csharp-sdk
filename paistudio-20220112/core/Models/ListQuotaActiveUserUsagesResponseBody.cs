// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotaActiveUserUsagesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of user resource usage details.</para>
        /// </summary>
        [NameInMap("QuotaUserUsage")]
        [Validation(Required=false)]
        public List<QuotaUser> QuotaUserUsage { get; set; }

        [NameInMap("QuotaUserUsages")]
        [Validation(Required=false)]
        public List<QuotaUser> QuotaUserUsages { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7C42CC7-2E85-508A-84F4-923B605FD10F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
