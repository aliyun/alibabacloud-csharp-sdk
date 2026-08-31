// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateComputeSourceRequest : TeaModel {
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
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The edit command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateComputeSourceRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateComputeSourceRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The associated cluster ID. This parameter takes effect only when CreateType is left empty or set to COMPUTE_SOURCE (to create a compute source that references a cluster). This parameter is mutually exclusive with CreateType=CLUSTER.</para>
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
            public List<UpdateComputeSourceRequestUpdateCommandConfigList> ConfigList { get; set; }
            public class UpdateComputeSourceRequestUpdateCommandConfigList : TeaModel {
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
                /// <para>The configuration item value.</para>
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
            /// <para>The creation entity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CLUSTER: Creates the entity as a cluster. ClusterId cannot be specified.</description></item>
            /// <item><description>COMPUTE_SOURCE: Creates the entity as a compute source. This is the default value.</description></item>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The compute source ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102311</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The compute source name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1021</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The compute source type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MacCompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The compute source type version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDH6</para>
            /// </summary>
            [NameInMap("TypeVersion")]
            [Validation(Required=false)]
            public string TypeVersion { get; set; }

        }

    }

}
