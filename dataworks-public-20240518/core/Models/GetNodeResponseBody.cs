// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>Data Studio node details.</para>
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public GetNodeResponseBodyNode Node { get; set; }
        public class GetNodeResponseBodyNode : TeaModel {
            /// <summary>
            /// <para>The time when the node was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700539206000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the Data Studio node.</para>
            /// <remarks>
            /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>860438872620113XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the node was last modified. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700539206000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196596664824XXXX</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The FlowSpec field information about this node. For more information, see <a href="https://github.com/aliyun/alibabacloud-dataworks-tool-dflow">FlowSpec</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;version&quot;: &quot;1.1.0&quot;,
            ///     &quot;kind&quot;: &quot;Node&quot;,
            ///     &quot;spec&quot;: {
            ///         &quot;nodes&quot;: [
            ///             {
            ///                 &quot;recurrence&quot;: &quot;Normal&quot;,
            ///                 &quot;id&quot;: &quot;860438872620113XXXX&quot;,
            ///                 &quot;timeout&quot;: 0,
            ///                 &quot;instanceMode&quot;: &quot;T+1&quot;,
            ///                 &quot;rerunMode&quot;: &quot;Allowed&quot;,
            ///                 &quot;rerunTimes&quot;: 3,
            ///                 &quot;rerunInterval&quot;: 180000,
            ///                 &quot;datasource&quot;: {
            ///                     &quot;name&quot;: &quot;odps_test&quot;,
            ///                     &quot;type&quot;: &quot;odps&quot;
            ///                 },
            ///                 &quot;script&quot;: {
            ///                     &quot;language&quot;: &quot;odps-sql&quot;,
            ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/ODPS_SQL_Test&quot;,
            ///                     &quot;runtime&quot;: {
            ///                         &quot;command&quot;: &quot;ODPS_SQL&quot;,
            ///                         &quot;commandTypeId&quot;: 10
            ///                     },
            ///                     &quot;content&quot;: &quot;select now();&quot;,
            ///                     &quot;id&quot;: &quot;853573334108680XXXX&quot;
            ///                 },
            ///                 &quot;trigger&quot;: {
            ///                     &quot;type&quot;: &quot;Scheduler&quot;,
            ///                     &quot;id&quot;: &quot;543680677872062XXXX&quot;,
            ///                     &quot;cron&quot;: &quot;00 00 00 * * ?&quot;,
            ///                     &quot;startTime&quot;: &quot;1970-01-01 00:00:00&quot;,
            ///                     &quot;endTime&quot;: &quot;9999-01-01 00:00:00&quot;,
            ///                     &quot;timezone&quot;: &quot;Asia/Shanghai&quot;,
            ///                     &quot;delaySeconds&quot;: 0
            ///                 },
            ///                 &quot;runtimeResource&quot;: {
            ///                     &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;,
            ///                     &quot;id&quot;: &quot;623731286945488XXXX&quot;,
            ///                     &quot;resourceGroupId&quot;: &quot;7201XXXX&quot;
            ///                 },
            ///                 &quot;name&quot;: &quot;ODPS_SQL_Test&quot;,
            ///                 &quot;owner&quot;: &quot;110755000425XXXX&quot;,
            ///                 &quot;metadata&quot;: {
            ///                     &quot;owner&quot;: &quot;110755000425XXXX&quot;,
            ///                     &quot;ownerName&quot;: &quot;<a href="mailto:XXXXX@test.XXX.com">XXXXX@test.XXX.com</a>&quot;,
            ///                     &quot;projectId&quot;: &quot;307XXX&quot;
            ///                 },
            ///                 &quot;inputs&quot;: {
            ///                     &quot;nodeOutputs&quot;: [
            ///                         {
            ///                             &quot;data&quot;: &quot;lwttest_standard_root&quot;,
            ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;
            ///                         }
            ///                     ]
            ///                 },
            ///                 &quot;outputs&quot;: {
            ///                     &quot;nodeOutputs&quot;: [
            ///                         {
            ///                             &quot;data&quot;: &quot;860438872620113XXXX&quot;,
            ///                             &quot;artifactType&quot;: &quot;NodeOutput&quot;,
            ///                             &quot;refTableName&quot;: &quot;ODPS_SQL_Test&quot;,
            ///                             &quot;isDefault&quot;: true
            ///                         }
            ///                     ]
            ///                 }
            ///             }
            ///         ],
            ///         &quot;flow&quot;: [
            ///             {
            ///                 &quot;nodeId&quot;: &quot;860438872620113XXXX&quot;,
            ///                 &quot;depends&quot;: [
            ///                     {
            ///                         &quot;type&quot;: &quot;Normal&quot;,
            ///                         &quot;output&quot;: &quot;lwttest_standard_root&quot;
            ///                     }
            ///                 ]
            ///             }
            ///         ]
            ///     },
            ///     &quot;metadata&quot;: {
            ///         &quot;uuid&quot;: &quot;860438872620113XXXX&quot;
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The ID of the corresponding scheduling task after the node is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>700006680527</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
