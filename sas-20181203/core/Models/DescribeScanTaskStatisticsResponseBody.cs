// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of risks that are handled for the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DealedRiskNum")]
        [Validation(Required=false)]
        public int? DealedRiskNum { get; set; }

        /// <summary>
        /// <para>The total number of tasks that are created for the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("PersonalTaskNum")]
        [Validation(Required=false)]
        public long? PersonalTaskNum { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>765EDBDE-1686-5DBA-B76F-2E0XXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of virus detection tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalTaskNum")]
        [Validation(Required=false)]
        public long? TotalTaskNum { get; set; }

        /// <summary>
        /// <para>The number of risks that are detected for the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("UserNum")]
        [Validation(Required=false)]
        public long? UserNum { get; set; }

    }

}
