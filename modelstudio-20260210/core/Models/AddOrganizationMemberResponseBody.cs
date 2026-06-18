// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class AddOrganizationMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddOrganizationMemberResponseBodyData Data { get; set; }
        public class AddOrganizationMemberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acc_123456789</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Indicates whether the seat was successfully assigned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SeatAssigned")]
            [Validation(Required=false)]
            public bool? SeatAssigned { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>385C2BC3-52FC-564F-9312-97E5DFE1DFC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
