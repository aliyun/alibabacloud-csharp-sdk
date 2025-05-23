// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckCustomConfigRequest : TeaModel {
        /// <summary>
        /// <para>Check item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>List of custom configuration items for the check item.</para>
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigRequestCustomConfigs> CustomConfigs { get; set; }
        public class VerifyCheckCustomConfigRequestCustomConfigs : TeaModel {
            /// <summary>
            /// <para>Name of the custom configuration item for the check item, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPList</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Operation type for the custom configuration item of the check item. Only pass DELETE when deleting; no need to pass for creation or update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>User-configured value string for the custom configuration item of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.4.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Repair parameters supported by the check item\&quot;s repair function.</para>
        /// </summary>
        [NameInMap("RepairConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigRequestRepairConfigs> RepairConfigs { get; set; }
        public class VerifyCheckCustomConfigRequestRepairConfigs : TeaModel {
            /// <summary>
            /// <para>ID of the repair process during the repair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7fec0a3395b345c18f108ffc9fc0****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>Name of the repair parameter for the check item, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPLists</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Operation type for the custom configuration item of the check item. Only pass DELETE when deleting; no need to pass for creation or update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>User-configured value string for the repair parameter of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.49.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
