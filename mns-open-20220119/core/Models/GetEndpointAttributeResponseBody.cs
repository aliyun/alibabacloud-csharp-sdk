// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEndpointAttributeResponseBodyData Data { get; set; }
        public class GetEndpointAttributeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of CIDR blocks.</para>
            /// </summary>
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<GetEndpointAttributeResponseBodyDataCidrList> CidrList { get; set; }
            public class GetEndpointAttributeResponseBodyDataCidrList : TeaModel {
                /// <summary>
                /// <para>The access control list (ACL) policy. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><b>allow</b>: The endpoint allows access from the specified CIDR block. This is the only supported value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("AclStrategy")]
                [Validation(Required=false)]
                public string AclStrategy { get; set; }

                /// <summary>
                /// <para>The CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.18.0.0/24</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The time when the CIDR block was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1701951224000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the endpoint is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EndpointEnabled")]
            [Validation(Required=false)]
            public bool? EndpointEnabled { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
