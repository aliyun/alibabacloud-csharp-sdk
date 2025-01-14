// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataSourceSharedRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The sharing rules of the data source.</para>
        /// </summary>
        [NameInMap("DataSourceSharedRules")]
        [Validation(Required=false)]
        public List<ListDataSourceSharedRulesResponseBodyDataSourceSharedRules> DataSourceSharedRules { get; set; }
        public class ListDataSourceSharedRulesResponseBodyDataSourceSharedRules : TeaModel {
            /// <summary>
            /// <para>The time when the rule was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724379762000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who creates the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The data source ID. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Dev</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the data source in the destination workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>targetProject.datasource</para>
            /// </summary>
            [NameInMap("SharedDataSourceName")]
            [Validation(Required=false)]
            public string SharedDataSourceName { get; set; }

            /// <summary>
            /// <para>The user in the workspace to which the data source is shared. If the data source is shared to the entire workspace, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SharedUser")]
            [Validation(Required=false)]
            public string SharedUser { get; set; }

            /// <summary>
            /// <para>The ID of the workspace with which the data source is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceProjectId")]
            [Validation(Required=false)]
            public long? SourceProjectId { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the data source is shared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TargetProjectId")]
            [Validation(Required=false)]
            public long? TargetProjectId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
