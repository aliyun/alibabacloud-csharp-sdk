// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstanceDiagnosisResultRequest : TeaModel {
        /// <summary>
        /// <para>The evaluation dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_analysis</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number for paging. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of authorization entries returned per page when paging. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The report date in the YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-08</para>
        /// </summary>
        [NameInMap("ReportDate")]
        [Validation(Required=false)]
        public string ReportDate { get; set; }

        /// <summary>
        /// <para>The status collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>healthy</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

    }

}
