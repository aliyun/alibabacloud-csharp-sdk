// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateComputeSourceRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateComputeSourceRequestCreateCommand CreateCommand { get; set; }
        public class CreateComputeSourceRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The ID of the associated cluster. This parameter takes effect only when CreateType is not specified or is set to COMPUTE_SOURCE, which creates a compute source that references a cluster. This parameter is mutually exclusive with CreateType=CLUSTER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102311</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public long? ClusterId { get; set; }

            /// <summary>
            /// <para>The connection configuration items.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<CreateComputeSourceRequestCreateCommandConfigList> ConfigList { get; set; }
            public class CreateComputeSourceRequestCreateCommandConfigList : TeaModel {
                /// <summary>
                /// <para>The configuration item.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the configuration item.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of entity to create. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CLUSTER: Creates a cluster. ClusterId cannot be specified.</description></item>
            /// <item><description>COMPUTE_SOURCE: Creates a compute source. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLUSTER</para>
            /// </summary>
            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the compute source.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1011</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the compute source.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MacCompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the compute source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDH6</para>
            /// </summary>
            [NameInMap("TypeVersion")]
            [Validation(Required=false)]
            public string TypeVersion { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
