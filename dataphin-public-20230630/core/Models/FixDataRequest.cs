// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class FixDataRequest : TeaModel {
        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment. </description></item>
        /// <item><description>PROD (default): production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The command to rerun downstream nodes to fix data link issues. You can choose to force a rerun.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FixDataCommand")]
        [Validation(Required=false)]
        public FixDataRequestFixDataCommand FixDataCommand { get; set; }
        public class FixDataRequestFixDataCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether to rerun the root instance. If you do not specify this parameter, the default value is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainRootInstance")]
            [Validation(Required=false)]
            public bool? ContainRootInstance { get; set; }

            /// <summary>
            /// <para>The downstream instances. If you have specified a downstream range, you do not need to specify this parameter. Otherwise, you must specify the list of downstream instances.</para>
            /// </summary>
            [NameInMap("DownStreamInstanceIdList")]
            [Validation(Required=false)]
            public List<FixDataRequestFixDataCommandDownStreamInstanceIdList> DownStreamInstanceIdList { get; set; }
            public class FixDataRequestFixDataCommandDownStreamInstanceIdList : TeaModel {
                /// <summary>
                /// <para>The field instance ID.</para>
                /// </summary>
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_2323421</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The downstream range. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_FAILED_INSTANCE: all failed instances.</description></item>
            /// <item><description>ALL_INSTANCE: all instances.</description></item>
            /// <item><description>ALL_FINAL_INSTANCE: all desired state instances.</description></item>
            /// <item><description>If you do not specify this parameter, the rerun is performed based on the specified downstream instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL_INSTANCE</para>
            /// </summary>
            [NameInMap("DownstreamRange")]
            [Validation(Required=false)]
            public string DownstreamRange { get; set; }

            /// <summary>
            /// <para>Specifies whether to force a rerun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceRerun")]
            [Validation(Required=false)]
            public bool? ForceRerun { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132344</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The root instance.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RootInstanceId")]
            [Validation(Required=false)]
            public FixDataRequestFixDataCommandRootInstanceId RootInstanceId { get; set; }
            public class FixDataRequestFixDataCommandRootInstanceId : TeaModel {
                /// <summary>
                /// <para>The field IDs. This parameter is available when the node is a logical table instance ID. If you do not specify this parameter, the full table is used by default.</para>
                /// </summary>
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_2323111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

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

    }

}
