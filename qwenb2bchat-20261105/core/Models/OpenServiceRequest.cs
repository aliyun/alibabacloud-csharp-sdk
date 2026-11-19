// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261105.Models
{
    public class OpenServiceRequest : TeaModel {
        /// <summary>
        /// <para>The business user identity. Provided according to the identity configuration bound to the gateway credential.</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public OpenServiceRequestCommunication Communication { get; set; }
        public class OpenServiceRequestCommunication : TeaModel {
            /// <summary>
            /// <para>The object that carries the customer business user identifier.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("user_info")]
            [Validation(Required=false)]
            public OpenServiceRequestCommunicationUserInfo UserInfo { get; set; }
            public class OpenServiceRequestCommunicationUserInfo : TeaModel {
                /// <summary>
                /// <para>The customer business user ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-user-001</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether to actually activate benefits. true enters the activation process, and false only validates the call and returns TEST_OK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("openBenefits")]
        [Validation(Required=false)]
        public bool? OpenBenefits { get; set; }

    }

}
