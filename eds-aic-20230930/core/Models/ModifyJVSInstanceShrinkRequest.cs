// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyJVSInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The target version of AI Engine, such as 2607W1. You can also set this parameter to latest to automatically resolve to the latest available version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply the configuration to all instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ApplyToAll")]
        [Validation(Required=false)]
        public bool? ApplyToAll { get; set; }

        /// <summary>
        /// <para>The Credit limit configuration. If you submit the configuration multiple times, the subsequent configurations overwrite the previous ones.</para>
        /// </summary>
        [NameInMap("CreditConfig")]
        [Validation(Required=false)]
        public List<ModifyJVSInstanceShrinkRequestCreditConfig> CreditConfig { get; set; }
        public class ModifyJVSInstanceShrinkRequestCreditConfig : TeaModel {
            /// <summary>
            /// <para>The credit limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CreditLimit")]
            [Validation(Required=false)]
            public long? CreditLimit { get; set; }

            /// <summary>
            /// <para>The dimension of the current credit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("LimitPeriod")]
            [Validation(Required=false)]
            public string LimitPeriod { get; set; }

        }

        /// <summary>
        /// <para>The custom display configuration. This parameter is optional. If you do not specify this parameter, the display configuration remains unchanged. If specified, it must contain at least one valid sub-field. Empty objects or null values are not accepted. Unspecified sub-fields retain their saved values for the node. ResolutionWidth and ResolutionHeight must be specified together. If only one of them is specified, the InvalidDisplayConfig error is returned. Valid values for Dpi range from 120 to 600. Dpi is supported only by matrix (CPS) nodes. If the target node contains an instance group (VM), specifying Dpi returns the InvalidDpi error for the entire batch. The effective time varies by node type. Modifications to an instance group (VM) take effect immediately. Modifications to a matrix (CPS) take effect after the next container creation, such as a restart or reset. This operation does not automatically restart the instance.</para>
        /// </summary>
        [NameInMap("DisplayConfig")]
        [Validation(Required=false)]
        public string DisplayConfigShrink { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-075cllfeuazh0****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultInstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

    }

}
