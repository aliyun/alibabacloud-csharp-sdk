// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckCustomConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the check item ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The list of custom configuration items for the check item.</para>
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigRequestCustomConfigs> CustomConfigs { get; set; }
        public class ChangeCheckCustomConfigRequestCustomConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the custom configuration item, which is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionTimeMax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation type of the custom configuration item. Set this parameter to DELETE only when deleting a configuration item. You do not need to specify this parameter for create or update operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the custom configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The region of the Security Center instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou:</b> China</description></item>
        /// <item><description><b>ap-southeast-1:</b> Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The repair parameters supported by the repair feature of the check item.</para>
        /// </summary>
        [NameInMap("RepairConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigRequestRepairConfigs> RepairConfigs { get; set; }
        public class ChangeCheckCustomConfigRequestRepairConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the repair flow used during the repair process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ascgrmscyjgs*********</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The name of the repair parameter, which is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Port</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation type of the custom configuration item. Set this parameter to DELETE only when deleting a configuration item. You do not need to specify this parameter for create or update operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the repair configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
