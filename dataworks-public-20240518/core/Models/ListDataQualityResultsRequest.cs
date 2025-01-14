// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityResultsRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-01</para>
        /// </summary>
        [NameInMap("BizdateFrom")]
        [Validation(Required=false)]
        public string BizdateFrom { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-04</para>
        /// </summary>
        [NameInMap("BizdateTo")]
        [Validation(Required=false)]
        public string BizdateTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTimeFrom")]
        [Validation(Required=false)]
        public long? CreateTimeFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTimeTo")]
        [Validation(Required=false)]
        public long? CreateTimeTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200001</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskId")]
        [Validation(Required=false)]
        public long? DataQualityEvaluationTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskInstanceId")]
        [Validation(Required=false)]
        public long? DataQualityEvaluationTaskInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("DataQualityRuleId")]
        [Validation(Required=false)]
        public long? DataQualityRuleId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
