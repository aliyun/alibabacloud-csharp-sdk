// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceControlConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance control configuration.</para>
        /// </summary>
        [NameInMap("InstanceControlConfiguration")]
        [Validation(Required=false)]
        public GetInstanceControlConfigurationResponseBodyInstanceControlConfiguration InstanceControlConfiguration { get; set; }
        public class GetInstanceControlConfigurationResponseBodyInstanceControlConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of control elements.</para>
            /// </summary>
            [NameInMap("ControlElements")]
            [Validation(Required=false)]
            public List<GetInstanceControlConfigurationResponseBodyInstanceControlConfigurationControlElements> ControlElements { get; set; }
            public class GetInstanceControlConfigurationResponseBodyInstanceControlConfigurationControlElements : TeaModel {
                /// <summary>
                /// <para>The element name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>human_verification</para>
                /// </summary>
                [NameInMap("ElementName")]
                [Validation(Required=false)]
                public string ElementName { get; set; }

                /// <summary>
                /// <para>The human verification configuration.</para>
                /// </summary>
                [NameInMap("HumanVerificationConfig")]
                [Validation(Required=false)]
                public GetInstanceControlConfigurationResponseBodyInstanceControlConfigurationControlElementsHumanVerificationConfig HumanVerificationConfig { get; set; }
                public class GetInstanceControlConfigurationResponseBodyInstanceControlConfigurationControlElementsHumanVerificationConfig : TeaModel {
                    /// <summary>
                    /// <para>The human verification type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>urn:alibaba:idaas:humanverification:alibaba-cloud-jigsaw-verification</para>
                    /// </summary>
                    [NameInMap("HumanVerificationType")]
                    [Validation(Required=false)]
                    public string HumanVerificationType { get; set; }

                }

                /// <summary>
                /// <para>The status of the control element.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
