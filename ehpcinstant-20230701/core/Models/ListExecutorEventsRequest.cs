// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListExecutorEventsRequest : TeaModel {
        /// <summary>
        /// <para>Queries the Executor filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListExecutorEventsRequestFilter Filter { get; set; }
        public class ListExecutorEventsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of executor IDs. A maximum of 100 IDs are supported.</para>
            /// </summary>
            [NameInMap("ExecutorIds")]
            [Validation(Required=false)]
            public List<string> ExecutorIds { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The level of the running event. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>Warning</description></item>
            /// <item><description>Error</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>For jobs submitted after this time, the time in the region is converted into a Unix timestamp (UI8 regionfor Aliyun sites).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeAfter")]
            [Validation(Required=false)]
            public long? TimeAfter { get; set; }

            /// <summary>
            /// <para>For jobs submitted before this time, the time in the region is converted into a Unix timestamp (UI8 regionfor Aliyun sites).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeBefore")]
            [Validation(Required=false)]
            public long? TimeBefore { get; set; }

        }

        /// <summary>
        /// <para>The current page number.\
        /// Starting value: 1\
        /// Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
