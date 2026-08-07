// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListOutboundCallRestrictionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOutboundCallRestrictionsResponseBodyData Data { get; set; }
        public class ListOutboundCallRestrictionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("OutboundCallRestrictions")]
            [Validation(Required=false)]
            public List<ListOutboundCallRestrictionsResponseBodyDataOutboundCallRestrictions> OutboundCallRestrictions { get; set; }
            public class ListOutboundCallRestrictionsResponseBodyDataOutboundCallRestrictions : TeaModel {
                /// <summary>
                /// <para>The creation time, in millisecond-level timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>The policy. Valid values:
                /// 0: blacklist.
                /// 1: whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public int? Policy { get; set; }

                /// <summary>
                /// <para>The remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The outbound call restriction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
                /// </summary>
                [NameInMap("RestrictionId")]
                [Validation(Required=false)]
                public string RestrictionId { get; set; }

            }

            /// <summary>
            /// <para>The page number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records that match the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance does not exist. Instance=392db13c-8901-4a25-b566-91d0d8114cec</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of variable values in the error message.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
