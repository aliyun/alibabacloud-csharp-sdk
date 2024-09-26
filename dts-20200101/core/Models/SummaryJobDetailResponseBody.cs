// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SummaryJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3m1213ye7l****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The returned information about the migrated or synchronized objects in arrays.</para>
        /// <remarks>
        /// <para> The arrays are in the following format: [{&quot;key&quot;:&quot;Function&quot;,&quot;state&quot;:5,&quot;totalCount&quot;:22},{&quot;key&quot;:&quot;Procedure&quot;,&quot;state&quot;:5,&quot;totalCount&quot;:26},{&quot;key&quot;:&quot;Table&quot;,&quot;state&quot;:0,&quot;totalCount&quot;:68},{&quot;key&quot;:&quot;View&quot;,&quot;state&quot;:5,&quot;totalCount&quot;:100}].</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ProgressSummaryDetails")]
        [Validation(Required=false)]
        public List<SummaryJobDetailResponseBodyProgressSummaryDetails> ProgressSummaryDetails { get; set; }
        public class SummaryJobDetailResponseBodyProgressSummaryDetails : TeaModel {
            /// <summary>
            /// <para>The type of migrated or synchronized object. Valid values: <b>Table</b>, <b>Constraint</b>, <b>Index</b>, <b>View</b>, <b>Materialize View</b>, <b>Type</b>, <b>Synonym</b>, <b>Trigger</b>, <b>Function</b>, <b>Procedure</b>, <b>Package</b>, <b>Default</b>, <b>Rule</b>, <b>PlanGuide</b>, and <b>Sequence</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The state of the data migration or data synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The task was complete.</description></item>
            /// <item><description><b>1</b>: The task was waiting to start.</description></item>
            /// <item><description><b>2</b>: The task was being initialized.</description></item>
            /// <item><description><b>3</b>: The task was in progress.</description></item>
            /// <item><description><b>4</b>: An error occurred.</description></item>
            /// <item><description><b>5</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// <para>The total number of migrated or synchronized objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9033138C-5AB3-5EB7-BA78-43131F19297C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
