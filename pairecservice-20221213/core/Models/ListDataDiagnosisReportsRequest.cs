// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListDataDiagnosisReportsRequest : TeaModel {
        /// <summary>
        /// <para>The end date. The format is YYYY-MM-DD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The feature name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature1</para>
        /// </summary>
        [NameInMap("FeatureName")]
        [Validation(Required=false)]
        public string FeatureName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The retention rate report type.</para>
        /// <list type="bullet">
        /// <item><description>Period: periodic report.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Period</para>
        /// </summary>
        [NameInMap("RemainRateType")]
        [Validation(Required=false)]
        public string RemainRateType { get; set; }

        /// <summary>
        /// <para>The start date. The format is YYYY-MM-DD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public long? TopN { get; set; }

    }

}
