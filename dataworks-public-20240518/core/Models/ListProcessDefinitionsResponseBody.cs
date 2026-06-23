// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProcessDefinitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListProcessDefinitionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListProcessDefinitionsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>A list of process definitions. For more information, see the <c>ProcessDefinition</c> object.</para>
            /// </summary>
            [NameInMap("ProcessDefinitions")]
            [Validation(Required=false)]
            public List<ListProcessDefinitionsResponseBodyPagingInfoProcessDefinitions> ProcessDefinitions { get; set; }
            public class ListProcessDefinitionsResponseBodyPagingInfoProcessDefinitions : TeaModel {
                /// <summary>
                /// <para>The description of the process definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lwt_ide_simple 项目 MaxCompute 表审批策略</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the process definition is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The ID of the process definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10354346</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a default system policy. System policies have restricted update capabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsSystem")]
                [Validation(Required=false)]
                public bool? IsSystem { get; set; }

                /// <summary>
                /// <para>The name of the process definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute 表审批</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The priority. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The phases in which the rule is effective. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Deployment</c>: The policy is checked when an application is submitted.</para>
                /// </description></item>
                /// <item><description><para><c>Running</c>: The policy is checked during process execution to determine if approval can be skipped. (Supported only for the MaxCompute type)</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("Scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>The subtype. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Table</para>
                /// </description></item>
                /// <item><description><para>Column</para>
                /// </description></item>
                /// <item><description><para>Database</para>
                /// </description></item>
                /// <item><description><para>Schema</para>
                /// </description></item>
                /// <item><description><para>Default</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The type of the process definition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>MaxCompute</para>
                /// </description></item>
                /// <item><description><para>DataService</para>
                /// </description></item>
                /// <item><description><para>Extension</para>
                /// </description></item>
                /// <item><description><para>Hologres</para>
                /// </description></item>
                /// <item><description><para>DlfV1 (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// <item><description><para>EMR (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// <item><description><para>DataAssetGovernance (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// <item><description><para>Lindorm (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// <item><description><para>StarRocks (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// <item><description><para>DlfNext (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// <item><description><para>DataWorks (You cannot create custom definitions for this type.)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
