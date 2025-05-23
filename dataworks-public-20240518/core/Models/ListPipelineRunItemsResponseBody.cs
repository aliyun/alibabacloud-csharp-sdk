// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPipelineRunItemsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListPipelineRunItemsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListPipelineRunItemsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PipelineRunItems")]
            [Validation(Required=false)]
            public List<ListPipelineRunItemsResponseBodyPagingInfoPipelineRunItems> PipelineRunItems { get; set; }
            public class ListPipelineRunItemsResponseBodyPagingInfoPipelineRunItems : TeaModel {
                /// <summary>
                /// <para>发布包创建时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724984066000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>860438872620113XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>创建人</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error Message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>修改时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724984066000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;version&quot;: &quot;1.1.0&quot;, &quot;kind&quot;: &quot;Node&quot;, &quot;spec&quot;: { &quot;nodes&quot;: [ { &quot;recurrence&quot;: &quot;Normal&quot;, &quot;id&quot;: &quot;860438872620113XXXX&quot;, &quot;timeout&quot;: 0, &quot;instanceMode&quot;: &quot;T+1&quot;, &quot;rerunMode&quot;: &quot;Allowed&quot;, &quot;rerunTimes&quot;: 3, &quot;rerunInterval&quot;: 180000, &quot;datasource&quot;: { &quot;name&quot;: &quot;odps_test&quot;, &quot;type&quot;: &quot;odps&quot; }, &quot;script&quot;: { &quot;language&quot;: &quot;odps-sql&quot;, &quot;path&quot;: &quot;XX/OpenAPI_Test/ODPS_SQL_Test&quot;, &quot;runtime&quot;: { &quot;command&quot;: &quot;ODPS_SQL&quot;, &quot;commandTypeId&quot;: 10 }, &quot;content&quot;: &quot;select now();&quot;, &quot;id&quot;: &quot;853573334108680XXXX&quot; }, &quot;trigger&quot;: { &quot;type&quot;: &quot;Scheduler&quot;, &quot;id&quot;: &quot;543680677872062XXXX&quot;, &quot;cron&quot;: &quot;00 00 00 * * ?&quot;, &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;, &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;, &quot;timezone&quot;: &quot;Asia/Shanghai&quot;, &quot;delaySeconds&quot;: 0 }, &quot;runtimeResource&quot;: { &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;, &quot;id&quot;: &quot;623731286945488XXXX&quot;, &quot;resourceGroupId&quot;: &quot;7201XXXX&quot; }, &quot;name&quot;: &quot;ODPS_SQL_Test&quot;, &quot;owner&quot;: &quot;110755000425XXXX&quot;, &quot;metadata&quot;: { &quot;owner&quot;: &quot;110755000425XXXX&quot;, &quot;ownerName&quot;: &quot;<a href="mailto:XXXXX@test.XXX.com">XXXXX@test.XXX.com</a>&quot;, &quot;projectId&quot;: &quot;307XXX&quot; }, &quot;inputs&quot;: { &quot;nodeOutputs&quot;: [ { &quot;data&quot;: &quot;lwttest_standard_root&quot;, &quot;artifactType&quot;: &quot;NodeOutput&quot; } ] }, &quot;outputs&quot;: { &quot;nodeOutputs&quot;: [ { &quot;data&quot;: &quot;860438872620113XXXX&quot;, &quot;artifactType&quot;: &quot;NodeOutput&quot;, &quot;refTableName&quot;: &quot;ODPS_SQL_Test&quot;, &quot;isDefault&quot;: true } ] } } ], &quot;flow&quot;: [ { &quot;nodeId&quot;: &quot;860438872620113XXXX&quot;, &quot;depends&quot;: [ { &quot;type&quot;: &quot;Normal&quot;, &quot;output&quot;: &quot;lwttest_standard_root&quot; } ] } ] }, &quot;metadata&quot;: { &quot;uuid&quot;: &quot;860438872620113XXXX&quot; } }</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>发布流程状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Node</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>项目Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C99E2BE6-9DEA-5C2E-8F51-1DDCFEADE490</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
