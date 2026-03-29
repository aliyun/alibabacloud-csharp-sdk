// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryDataDiagnosisStatisticsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-08</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Period</para>
        /// </summary>
        [NameInMap("RemainRateType")]
        [Validation(Required=false)]
        public string RemainRateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
