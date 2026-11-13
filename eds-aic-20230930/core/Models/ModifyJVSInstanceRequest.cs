// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyJVSInstanceRequest : TeaModel {
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
        public List<ModifyJVSInstanceRequestCreditConfig> CreditConfig { get; set; }
        public class ModifyJVSInstanceRequestCreditConfig : TeaModel {
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
        public ModifyJVSInstanceRequestDisplayConfig DisplayConfig { get; set; }
        public class ModifyJVSInstanceRequestDisplayConfig : TeaModel {
            /// <summary>
            /// <para>The display density in dpi. Valid values: 120 to 600. The value must be an integer. This parameter is supported only by the matrix (CPS) form. The instance group (VM) form does not support display density. If you specify this parameter for an instance group, InvalidDpi is returned for the entire batch. The display density for the instance group form is derived from the resolution. If this parameter is not specified, the saved value for the node is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("Dpi")]
            [Validation(Required=false)]
            public int? Dpi { get; set; }

            /// <summary>
            /// <para>The resolution height in pixels. The value must be an even number. The valid range varies by instance form: 300 to 3000 for an instance group (VM), and 480 to 2640 for a matrix (CPS). This parameter must be specified together with ResolutionWidth. If this parameter is not specified, the saved height for the node is retained. The width and height are validated separately, and there are no restrictions on the aspect ratio or the size relationship between width and height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <para>The resolution width in pixels. The value must be an even number. The valid range varies by instance form: 300 to 3000 for an instance group (VM), and 480 to 2640 for a matrix (CPS). This parameter must be specified together with ResolutionHeight. If this parameter is not specified, the saved width for the node is retained. If the value exceeds the valid range for the corresponding form, InvalidResolution is returned. The valid range for the matrix form is determined by the server configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

        }

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
