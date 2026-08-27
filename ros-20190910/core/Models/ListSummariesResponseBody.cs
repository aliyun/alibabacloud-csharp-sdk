// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>Statistics about the number of central ROS resources.</para>
        /// </summary>
        [NameInMap("CenterSummary")]
        [Validation(Required=false)]
        public ListSummariesResponseBodyCenterSummary CenterSummary { get; set; }
        public class ListSummariesResponseBodyCenterSummary : TeaModel {
            /// <summary>
            /// <para>The number of registered resource types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RegisteredResourceTypeCount")]
            [Validation(Required=false)]
            public int? RegisteredResourceTypeCount { get; set; }

            /// <summary>
            /// <para>The number of templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TemplateCount")]
            [Validation(Required=false)]
            public string TemplateCount { get; set; }

        }

        /// <summary>
        /// <para>Statistics about the number of Resource Orchestration Service (ROS) resources in each region.</para>
        /// </summary>
        [NameInMap("RegionSummaries")]
        [Validation(Required=false)]
        public List<ListSummariesResponseBodyRegionSummaries> RegionSummaries { get; set; }
        public class ListSummariesResponseBodyRegionSummaries : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of stacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StackCount")]
            [Validation(Required=false)]
            public string StackCount { get; set; }

            /// <summary>
            /// <para>Stack details.</para>
            /// </summary>
            [NameInMap("StackDetails")]
            [Validation(Required=false)]
            public List<ListSummariesResponseBodyRegionSummariesStackDetails> StackDetails { get; set; }
            public class ListSummariesResponseBodyRegionSummariesStackDetails : TeaModel {
                /// <summary>
                /// <para>The brief status of the stack. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>IN_PROGRESS: In progress (including creation, update, deletion, rollback, import creation, and import update in progress).</para>
                /// </description></item>
                /// <item><description><para>COMPLETE: Complete (including successful creation, update, deletion, rollback, import creation, and import update).</para>
                /// </description></item>
                /// <item><description><para>FAILED: Failed (including failed creation, update, deletion, rollback, import creation, and import update).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("BriefStatus")]
                [Validation(Required=false)]
                public string BriefStatus { get; set; }

                /// <summary>
                /// <para>The number of stacks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

            }

            /// <summary>
            /// <para>The number of stack groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StackGroupCount")]
            [Validation(Required=false)]
            public string StackGroupCount { get; set; }

            /// <summary>
            /// <para>The number of resource scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateScratchCount")]
            [Validation(Required=false)]
            public int? TemplateScratchCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B842BB91-A004-59CC-83E3-C961567FCBC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
