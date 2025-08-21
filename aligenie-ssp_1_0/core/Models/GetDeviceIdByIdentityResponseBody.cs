// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceIdByIdentityResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7DA****A0726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetDeviceIdByIdentityResponseBodyResult Result { get; set; }
        public class GetDeviceIdByIdentityResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>A963*0158</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            [NameInMap("DeviceUnionIds")]
            [Validation(Required=false)]
            public List<GetDeviceIdByIdentityResponseBodyResultDeviceUnionIds> DeviceUnionIds { get; set; }
            public class GetDeviceIdByIdentityResponseBodyResultDeviceUnionIds : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1553*B0C3</para>
                /// </summary>
                [NameInMap("DeviceUnionId")]
                [Validation(Required=false)]
                public string DeviceUnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1**2</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

        }

    }

}
