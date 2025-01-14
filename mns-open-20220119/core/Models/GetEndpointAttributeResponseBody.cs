// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEndpointAttributeResponseBodyData Data { get; set; }
        public class GetEndpointAttributeResponseBodyData : TeaModel {
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<GetEndpointAttributeResponseBodyDataCidrList> CidrList { get; set; }
            public class GetEndpointAttributeResponseBodyDataCidrList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("AclStrategy")]
                [Validation(Required=false)]
                public string AclStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>172.18.0.0/24</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1701951224000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EndpointEnabled")]
            [Validation(Required=false)]
            public bool? EndpointEnabled { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
