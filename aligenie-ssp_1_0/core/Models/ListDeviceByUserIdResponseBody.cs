// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListDeviceByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned error code, where 200 indicates that the invocation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return result of invoking this API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed information returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDeviceByUserIdResponseBodyResult> Result { get; set; }
        public class ListDeviceByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The openId corresponding to the Device Information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A963*0158</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            /// <summary>
            /// <para>Organization ID and UnionId information corresponding to the device.</para>
            /// </summary>
            [NameInMap("DeviceUnionIds")]
            [Validation(Required=false)]
            public List<ListDeviceByUserIdResponseBodyResultDeviceUnionIds> DeviceUnionIds { get; set; }
            public class ListDeviceByUserIdResponseBodyResultDeviceUnionIds : TeaModel {
                /// <summary>
                /// <para>The UnionId of the device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553*B0C3</para>
                /// </summary>
                [NameInMap("DeviceUnionId")]
                [Validation(Required=false)]
                public string DeviceUnionId { get; set; }

                /// <summary>
                /// <para>The organization ID.</para>
                /// 
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
