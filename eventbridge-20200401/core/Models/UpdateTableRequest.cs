// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateTableRequest : TeaModel {
        /// <summary>
        /// <para>Add column</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;,&quot;Comment&quot;:&quot;主键&quot;}</para>
        /// </summary>
        [NameInMap("AddColumn")]
        [Validation(Required=false)]
        public UpdateTableRequestAddColumn AddColumn { get; set; }
        public class UpdateTableRequestAddColumn : TeaModel {
            /// <summary>
            /// <para>Comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>接口授权_刘宏月_申请测试环境服务器资源访问权限_2026-07-06</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The full name of the queried event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-default-agent-alikafka_pre-cn-28t3sfzno003</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The event target type. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Data catalog to which it belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Idempotency token</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e9b8f60-3a2c-4d7e-9f1b-8c3d5e7a2b4f</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Delete column</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;old_column&quot;}</para>
        /// </summary>
        [NameInMap("DeleteColumn")]
        [Validation(Required=false)]
        public UpdateTableRequestDeleteColumn DeleteColumn { get; set; }
        public class UpdateTableRequestDeleteColumn : TeaModel {
            /// <summary>
            /// <para>Connector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-default-agent-alikafka_pre-cn-28t3sfzno003</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Table name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Namespace to which it belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Rename column</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;old_name&quot;,&quot;NewName&quot;:&quot;new_name&quot;}</para>
        /// </summary>
        [NameInMap("RenameColumn")]
        [Validation(Required=false)]
        public UpdateTableRequestRenameColumn RenameColumn { get; set; }
        public class UpdateTableRequestRenameColumn : TeaModel {
            /// <summary>
            /// <para>Connector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-default-agent-alikafka_pre-cn-28t3sfzno003</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The updated name. Enter this when you need to modify the metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fvt-oos-application-group-56ca74b000</para>
            /// </summary>
            [NameInMap("NewName")]
            [Validation(Required=false)]
            public string NewName { get; set; }

        }

        /// <summary>
        /// <para>Update column comment</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Comment&quot;:&quot;主键ID&quot;}</para>
        /// </summary>
        [NameInMap("UpdateColumnComment")]
        [Validation(Required=false)]
        public UpdateTableRequestUpdateColumnComment UpdateColumnComment { get; set; }
        public class UpdateTableRequestUpdateColumnComment : TeaModel {
            /// <summary>
            /// <para>Comment information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIUS Dev 环境</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Extended data name</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-default-agent-alikafka_pre-cn-28t3sfzno003</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Update column type</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;}</para>
        /// </summary>
        [NameInMap("UpdateColumnType")]
        [Validation(Required=false)]
        public UpdateTableRequestUpdateColumnType UpdateColumnType { get; set; }
        public class UpdateTableRequestUpdateColumnType : TeaModel {
            /// <summary>
            /// <para>Connector name</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-default-agent-alikafka_pre-cn-28t3sfzno003</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Column type</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Update table comment</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的备注</para>
        /// </summary>
        [NameInMap("UpdateComment")]
        [Validation(Required=false)]
        public string UpdateComment { get; set; }

        /// <summary>
        /// <para>Update retention policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HotTTL&quot;:7,&quot;ColdTTL&quot;:30}</para>
        /// </summary>
        [NameInMap("UpdateRetentionPolicy")]
        [Validation(Required=false)]
        public UpdateTableRequestUpdateRetentionPolicy UpdateRetentionPolicy { get; set; }
        public class UpdateTableRequestUpdateRetentionPolicy : TeaModel {
            /// <summary>
            /// <para>Cold storage duration</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("ColdTTL")]
            [Validation(Required=false)]
            public int? ColdTTL { get; set; }

            /// <summary>
            /// <para>Hot storage duration</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("HotTTL")]
            [Validation(Required=false)]
            public int? HotTTL { get; set; }

        }

    }

}
