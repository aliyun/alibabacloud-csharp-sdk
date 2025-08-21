// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetUserByDeviceIdResponseBody : TeaModel {
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
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUserByDeviceIdResponseBodyResult Result { get; set; }
        public class GetUserByDeviceIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0963*0158</para>
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

            [NameInMap("UserUnionIds")]
            [Validation(Required=false)]
            public List<GetUserByDeviceIdResponseBodyResultUserUnionIds> UserUnionIds { get; set; }
            public class GetUserByDeviceIdResponseBodyResultUserUnionIds : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1**2</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1553*B0C3</para>
                /// </summary>
                [NameInMap("UserUnionId")]
                [Validation(Required=false)]
                public string UserUnionId { get; set; }

            }

        }

    }

}
