// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDataSourceTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC5EC8FA-5C0D-56AF-BEF4-6FCCEABD0511</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The index information.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataSourceTasksResponseBodyResult> Result { get; set; }
        public class ListDataSourceTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The additional attributes of the card.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;consoleVersion&quot;: &quot;&quot;,
            ///     &quot;domain&quot;: &quot;hz_pre_vpc_domain_1&quot;,
            ///     &quot;configType&quot;: &quot;offline&quot;
            /// }</para>
            /// </summary>
            [NameInMap("extraAttribute")]
            [Validation(Required=false)]
            public string ExtraAttribute { get; set; }

            /// <summary>
            /// <para>The field3 field that was passed when the FSM was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;ha-cn-pl32rf0****_offline_adv&quot;: 1,
            ///     &quot;ha-cn-pl32rf0****_offline_plugin&quot;: 1,
            ///     &quot;ha-cn-pl32rf0****_table_ha-cn-35t3r02iq03_test_api&quot;: 1,
            ///     &quot;ha-cn-pl32rf0****@ha-cn-pl32rf0****_test_api@hz_pre_vpc_domain_1@test_api@index_config&quot;: 1,
            ///     &quot;ha-cn-pl32rf0****_offline_dict&quot;: 1
            /// }</para>
            /// </summary>
            [NameInMap("field3")]
            [Validation(Required=false)]
            public string Field3 { get; set; }

            /// <summary>
            /// <para>The ID of the finite state machine (FSM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>tisplus_opensearch@datasource_flow_fsm@1865410598556969-ha-cn-pl32rf0****_api2@bj_vpc_domain_1@null@MANUAL-ha-cn-pl32rf0****_api2@1649729867698@028315</para>
            /// </summary>
            [NameInMap("fsmId")]
            [Validation(Required=false)]
            public string FsmId { get; set; }

            /// <summary>
            /// <para>The change group type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Table_Update</para>
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The card name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_qrs</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The FSM status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>onlyPublished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the progress bar.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListDataSourceTasksResponseBodyResultTags> Tags { get; set; }
            public class ListDataSourceTasksResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-tag</para>
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The tag level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("tagLevel")]
                [Validation(Required=false)]
                public string TagLevel { get; set; }

            }

            /// <summary>
            /// <para>The task information.</para>
            /// </summary>
            [NameInMap("taskNodes")]
            [Validation(Required=false)]
            public List<ListDataSourceTasksResponseBodyResultTaskNodes> TaskNodes { get; set; }
            public class ListDataSourceTasksResponseBodyResultTaskNodes : TeaModel {
                /// <summary>
                /// <para>The time when the task was complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-17 18:40:48</para>
                /// </summary>
                [NameInMap("finishDate")]
                [Validation(Required=false)]
                public string FinishDate { get; set; }

                /// <summary>
                /// <para>The ordinal number of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>publish config version</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The timestamp of the card.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1646279473</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The card type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mra_table_config_trace_fsm</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user who triggered the generation of the FSM process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
