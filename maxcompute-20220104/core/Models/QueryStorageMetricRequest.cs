// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryStorageMetricRequest : TeaModel {
        /// <summary>
        /// <para>The names of the projects.</para>
        /// </summary>
        [NameInMap("projectList")]
        [Validation(Required=false)]
        public List<string> ProjectList { get; set; }

        /// <summary>
        /// <para>The storage class. Valid values include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>totalStorage</para>
        /// </description></item>
        /// <item><description><para>longTermStorage</para>
        /// </description></item>
        /// <item><description><para>lowFreqStorage</para>
        /// </description></item>
        /// <item><description><para>standardStorage</para>
        /// </description></item>
        /// <item><description><para>recycleBinStorage</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("typeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735534322</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
