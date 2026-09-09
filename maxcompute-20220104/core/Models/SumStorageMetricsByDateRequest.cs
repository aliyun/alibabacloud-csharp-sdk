// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByDateRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value must be a timestamp in milliseconds. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718590596556</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The project names. If this parameter is not specified, the data of all projects is returned.</para>
        /// </summary>
        [NameInMap("projectNames")]
        [Validation(Required=false)]
        public List<string> ProjectNames { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value must be a timestamp in milliseconds. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715393576201</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The dimension for aggregating storage metrics. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PROJECT</c></para>
        /// </description></item>
        /// <item><description><para><c>STORAGE_TYPE</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROJECT</para>
        /// </summary>
        [NameInMap("statsType")]
        [Validation(Required=false)]
        public string StatsType { get; set; }

    }

}
