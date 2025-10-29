// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPipelineRunItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListPipelineRunItemsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListPipelineRunItemsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of deployments.</para>
            /// </summary>
            [NameInMap("PipelineRunItems")]
            [Validation(Required=false)]
            public List<ListPipelineRunItemsResponseBodyPagingInfoPipelineRunItems> PipelineRunItems { get; set; }
            public class ListPipelineRunItemsResponseBodyPagingInfoPipelineRunItems : TeaModel {
                /// <summary>
                /// <para>The deployment creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724984066000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The unique identifier of the deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>860438872620113XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The error message if the deployment failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error Message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The time when the deployment was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724984066000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The deployment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The FlowSpec information describing this deployment. For detailed specifications, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;version&quot;: &quot;1.1.0&quot;, &quot;kind&quot;: &quot;Node&quot;, &quot;spec&quot;: { &quot;nodes&quot;: [ { &quot;recurrence&quot;: &quot;Normal&quot;, &quot;id&quot;: &quot;860438872620113XXXX&quot;, &quot;timeout&quot;: 0, &quot;instanceMode&quot;: &quot;T+1&quot;, &quot;rerunMode&quot;: &quot;Allowed&quot;, &quot;rerunTimes&quot;: 3, &quot;rerunInterval&quot;: 180000, &quot;datasource&quot;: { &quot;name&quot;: &quot;odps_test&quot;, &quot;type&quot;: &quot;odps&quot; }, &quot;script&quot;: { &quot;language&quot;: &quot;odps-sql&quot;, &quot;path&quot;: &quot;XX/OpenAPI_Test/ODPS_SQL_Test&quot;, &quot;runtime&quot;: { &quot;command&quot;: &quot;ODPS_SQL&quot;, &quot;commandTypeId&quot;: 10 }, &quot;content&quot;: &quot;select now();&quot;, &quot;id&quot;: &quot;853573334108680XXXX&quot; }, &quot;trigger&quot;: { &quot;type&quot;: &quot;Scheduler&quot;, &quot;id&quot;: &quot;543680677872062XXXX&quot;, &quot;cron&quot;: &quot;00 00 00 * * ?&quot;, &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;, &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;, &quot;timezone&quot;: &quot;Asia/Shanghai&quot;, &quot;delaySeconds&quot;: 0 }, &quot;runtimeResource&quot;: { &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;, &quot;id&quot;: &quot;623731286945488XXXX&quot;, &quot;resourceGroupId&quot;: &quot;7201XXXX&quot; }, &quot;name&quot;: &quot;ODPS_SQL_Test&quot;, &quot;owner&quot;: &quot;110755000425XXXX&quot;, &quot;metadata&quot;: { &quot;owner&quot;: &quot;110755000425XXXX&quot;, &quot;ownerName&quot;: &quot;<a href="mailto:XXXXX@test.XXX.com">XXXXX@test.XXX.com</a>&quot;, &quot;projectId&quot;: &quot;307XXX&quot; }, &quot;inputs&quot;: { &quot;nodeOutputs&quot;: [ { &quot;data&quot;: &quot;lwttest_standard_root&quot;, &quot;artifactType&quot;: &quot;NodeOutput&quot; } ] }, &quot;outputs&quot;: { &quot;nodeOutputs&quot;: [ { &quot;data&quot;: &quot;860438872620113XXXX&quot;, &quot;artifactType&quot;: &quot;NodeOutput&quot;, &quot;refTableName&quot;: &quot;ODPS_SQL_Test&quot;, &quot;isDefault&quot;: true } ] } } ], &quot;flow&quot;: [ { &quot;nodeId&quot;: &quot;860438872620113XXXX&quot;, &quot;depends&quot;: [ { &quot;type&quot;: &quot;Normal&quot;, &quot;output&quot;: &quot;lwttest_standard_root&quot; } ] } ] }, &quot;metadata&quot;: { &quot;uuid&quot;: &quot;860438872620113XXXX&quot; } }</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The deployment status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Init: Initializing</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Success</description></item>
                /// <item><description>Fail</description></item>
                /// <item><description>Termination</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The deployment type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Node</description></item>
                /// <item><description>WorkflowDefinition: Workflow definition.</description></item>
                /// <item><description>Resource</description></item>
                /// <item><description>Function: The object is a function.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Node</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The deployment version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that match the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues if errors occur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C99E2BE6-9DEA-5C2E-8F51-1DDCFEADE490</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
