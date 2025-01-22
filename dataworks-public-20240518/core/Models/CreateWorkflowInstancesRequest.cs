// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateWorkflowInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStartEnabled")]
        [Validation(Required=false)]
        public bool? AutoStartEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>create for test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("DefaultRunProperties")]
        [Validation(Required=false)]
        public CreateWorkflowInstancesRequestDefaultRunProperties DefaultRunProperties { get; set; }
        public class CreateWorkflowInstancesRequestDefaultRunProperties : TeaModel {
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesAlert Alert { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesAlert : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Sms</para>
                /// </summary>
                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Succes</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesAnalysis Analysis { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesAnalysis : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Blocked")]
                [Validation(Required=false)]
                public bool? Blocked { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("ExcludeProjectIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeProjectIds { get; set; }

            [NameInMap("ExcludeTaskIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTaskIds { get; set; }

            [NameInMap("IncludeProjectIds")]
            [Validation(Required=false)]
            public List<long?> IncludeProjectIds { get; set; }

            [NameInMap("IncludeTaskIds")]
            [Validation(Required=false)]
            public List<long?> IncludeTaskIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ManualSelection</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Asc</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            [NameInMap("RootTaskIds")]
            [Validation(Required=false)]
            public List<long?> RootTaskIds { get; set; }

            [NameInMap("RunPolicy")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesRunPolicy RunPolicy { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesRunPolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>23:59:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Immediately")]
                [Validation(Required=false)]
                public bool? Immediately { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Daily</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public string RuntimeResource { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Periods")]
        [Validation(Required=false)]
        public CreateWorkflowInstancesRequestPeriods Periods { get; set; }
        public class CreateWorkflowInstancesRequestPeriods : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("BizDates")]
            [Validation(Required=false)]
            public List<CreateWorkflowInstancesRequestPeriodsBizDates> BizDates { get; set; }
            public class CreateWorkflowInstancesRequestPeriodsBizDates : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-24</para>
                /// </summary>
                [NameInMap("EndBizDate")]
                [Validation(Required=false)]
                public string EndBizDate { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-20</para>
                /// </summary>
                [NameInMap("StartBizDate")]
                [Validation(Required=false)]
                public string StartBizDate { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23:59:59</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;1001&quot;: &quot;key1=val2 key2=val2&quot;, 
        ///   &quot;1002&quot;: &quot;key1=val2 key2=val2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskParameters")]
        [Validation(Required=false)]
        public string TaskParameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SupplementData</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 
        ///   &quot;key1&quot;: &quot;value1&quot;, 
        ///   &quot;key2&quot;: &quot;value2&quot; 
        /// }</para>
        /// </summary>
        [NameInMap("WorkflowParameters")]
        [Validation(Required=false)]
        public string WorkflowParameters { get; set; }

    }

}
