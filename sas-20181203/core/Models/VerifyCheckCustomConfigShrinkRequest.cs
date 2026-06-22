// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckCustomConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The input parameters for custom check item validation.</para>
        /// </summary>
        [NameInMap("CustomCheckConfig")]
        [Validation(Required=false)]
        public string CustomCheckConfigShrink { get; set; }

        /// <summary>
        /// <para>The list of custom parameter configuration items for the check item.</para>
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigShrinkRequestCustomConfigs> CustomConfigs { get; set; }
        public class VerifyCheckCustomConfigShrinkRequestCustomConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the custom configuration item for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPList</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation type of the custom configuration item for the check item. Set this parameter to DELETE only for deletion operations. You do not need to specify this parameter for creation or update operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the custom configuration item for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.4.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The repair parameters supported by the repair feature of the check item.</para>
        /// </summary>
        [NameInMap("RepairConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigShrinkRequestRepairConfigs> RepairConfigs { get; set; }
        public class VerifyCheckCustomConfigShrinkRequestRepairConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the repair flow that corresponds to the repair operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7fec0a3395b345c18f108ffc9fc0****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The name of the repair parameter for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPLists</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation type of the custom configuration item for the check item. Set this parameter to DELETE only for deletion operations. You do not need to specify this parameter for creation or update operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the repair configuration item for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.49.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validation type for Threat Detection Service parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>REPAIR_CONFIG</b>: repair and custom parameter validation (default).</description></item>
        /// <item><description><b>CHECK_ITEM_CONFIG</b>: custom check item validation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REPAIR_CONFIG</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
