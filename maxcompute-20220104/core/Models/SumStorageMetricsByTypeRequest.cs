// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByTypeRequest : TeaModel {
        /// <summary>
        /// <para>Required. The query end time, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718590596556</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>An array of project names.</para>
        /// </summary>
        [NameInMap("projectNames")]
        [Validation(Required=false)]
        public List<string> ProjectNames { get; set; }

        /// <summary>
        /// <para>Required. The query start time, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715393576201</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The dimension for aggregating statistics. Valid values: <c>PROJECT</c> (by project) and <c>STORAGE_TYPE</c> (by storage type).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROJECT</para>
        /// </summary>
        [NameInMap("statsType")]
        [Validation(Required=false)]
        public string StatsType { get; set; }

    }

}
