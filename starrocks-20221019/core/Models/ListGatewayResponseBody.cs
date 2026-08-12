// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ListGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewayResponseBodyData> Data { get; set; }
        public class ListGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether public network access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnablePublicNet")]
            [Validation(Required=false)]
            public bool? EnablePublicNet { get; set; }

            /// <summary>
            /// <para>The number of gateway nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FeNodeNumber")]
            [Validation(Required=false)]
            public int? FeNodeNumber { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13822</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The gateway name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Gateway 1</para>
            /// </summary>
            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            /// <summary>
            /// <para>The gateway type. Valid values are \<c>Slb\\</c> and \<c>Privatezone\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// <para>The internal endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe-c-b25e21e24388****-ab8sjd-internal.starrocks.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternalDomain")]
            [Validation(Required=false)]
            public string InternalDomain { get; set; }

            /// <summary>
            /// <para>The ID of the internal-facing Server Load Balancer (SLB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-123abc</para>
            /// </summary>
            [NameInMap("InternalSlbId")]
            [Validation(Required=false)]
            public string InternalSlbId { get; set; }

            /// <summary>
            /// <para>The ID of the PrivateZone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a62des2123243881b9s2sa220k2l38m9</para>
            /// </summary>
            [NameInMap("PrivatezoneId")]
            [Validation(Required=false)]
            public string PrivatezoneId { get; set; }

            /// <summary>
            /// <para>The public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe-c-b25e21e24388****-8s272d.starrocks.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PublicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// <para>The ID of the access control list (ACL) for public network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-hsb123ksi2</para>
            /// </summary>
            [NameInMap("PublicSlbAclId")]
            [Validation(Required=false)]
            public string PublicSlbAclId { get; set; }

            /// <summary>
            /// <para>The ID of the public-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-abc123</para>
            /// </summary>
            [NameInMap("PublicSlbId")]
            [Validation(Required=false)]
            public string PublicSlbId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
