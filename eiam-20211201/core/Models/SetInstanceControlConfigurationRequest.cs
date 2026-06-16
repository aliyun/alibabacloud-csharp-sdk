// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetInstanceControlConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The control items for the instance.</para>
        /// </summary>
        [NameInMap("ControlElements")]
        [Validation(Required=false)]
        public List<SetInstanceControlConfigurationRequestControlElements> ControlElements { get; set; }
        public class SetInstanceControlConfigurationRequestControlElements : TeaModel {
            /// <summary>
            /// <para>The name of the control item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>human_verification</para>
            /// </summary>
            [NameInMap("ElementName")]
            [Validation(Required=false)]
            public string ElementName { get; set; }

            /// <summary>
            /// <para>The CAPTCHA configuration.</para>
            /// </summary>
            [NameInMap("HumanVerificationConfig")]
            [Validation(Required=false)]
            public SetInstanceControlConfigurationRequestControlElementsHumanVerificationConfig HumanVerificationConfig { get; set; }
            public class SetInstanceControlConfigurationRequestControlElementsHumanVerificationConfig : TeaModel {
                /// <summary>
                /// <para>The CAPTCHA type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:alibaba:idaas:humanverification:alibaba-cloud-slider-verification</para>
                /// </summary>
                [NameInMap("HumanVerificationType")]
                [Validation(Required=false)]
                public string HumanVerificationType { get; set; }

            }

            /// <summary>
            /// <para>The status of the control item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
