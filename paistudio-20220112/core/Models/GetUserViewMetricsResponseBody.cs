// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetUserViewMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>资源组ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>用户监控数据。</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public UserViewMetric Summary { get; set; }

        /// <summary>
        /// <para>总条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>按照用户维度统计的指标</para>
        /// </summary>
        [NameInMap("UserMetrics")]
        [Validation(Required=false)]
        public List<UserViewMetric> UserMetrics { get; set; }

    }

}
