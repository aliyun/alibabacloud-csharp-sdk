// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstanceDiagnosisResultRequest : TeaModel {
        /// <summary>
        /// <para>Evaluation dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_analysis</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number for paged queries. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of authorized entries displayed per page for paged queries. The default value is 10, and the maximum value is 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Report time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-08</para>
        /// </summary>
        [NameInMap("ReportDate")]
        [Validation(Required=false)]
        public string ReportDate { get; set; }

        /// <summary>
        /// <para>Status collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>healthy</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

    }

}
