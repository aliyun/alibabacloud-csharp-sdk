// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetUserViewMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The user monitoring data.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public UserViewMetric Summary { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The metrics aggregated at the user dimension.</para>
        /// </summary>
        [NameInMap("UserMetrics")]
        [Validation(Required=false)]
        public List<UserViewMetric> UserMetrics { get; set; }

    }

}
