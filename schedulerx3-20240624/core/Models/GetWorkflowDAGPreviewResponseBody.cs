// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetWorkflowDAGPreviewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowDAGPreviewResponseBodyData Data { get; set; }
        public class GetWorkflowDAGPreviewResponseBodyData : TeaModel {
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public List<GetWorkflowDAGPreviewResponseBodyDataEdges> Edges { get; set; }
            public class GetWorkflowDAGPreviewResponseBodyDataEdges : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public long? Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public long? Target { get; set; }

            }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetWorkflowDAGPreviewResponseBodyDataNodes> Nodes { get; set; }
            public class GetWorkflowDAGPreviewResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>settle-job</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Coordinate")]
                [Validation(Required=false)]
                public GetWorkflowDAGPreviewResponseBodyDataNodesCoordinate Coordinate { get; set; }
                public class GetWorkflowDAGPreviewResponseBodyDataNodesCoordinate : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public float? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public float? Width { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all_success</para>
                /// </summary>
                [NameInMap("DependentStrategy")]
                [Validation(Required=false)]
                public int? DependentStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>script_shell</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8733786-C045-59F1-8D79-99A52863F62D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
