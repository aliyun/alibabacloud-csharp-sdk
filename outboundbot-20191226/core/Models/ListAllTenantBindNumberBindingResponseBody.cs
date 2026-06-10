// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAllTenantBindNumberBindingResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAllTenantBindNumberBindingResponseBodyData Data { get; set; }
        public class ListAllTenantBindNumberBindingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Array.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAllTenantBindNumberBindingResponseBodyDataList> List { get; set; }
            public class ListAllTenantBindNumberBindingResponseBodyDataList : TeaModel {
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                /// <summary>
                /// <para>Binding ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b5bfb844-ce85-4779-bc8f-161fba46aa07</para>
                /// </summary>
                [NameInMap("BindingId")]
                [Validation(Required=false)]
                public string BindingId { get; set; }

                /// <summary>
                /// <para>List of instance names.</para>
                /// </summary>
                [NameInMap("InstanceNameList")]
                [Validation(Required=false)]
                public List<string> InstanceNameList { get; set; }

                /// <summary>
                /// <para>Phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15005059355</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>Policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;rateLimitPeriod\&quot;:\&quot;1\&quot;,\&quot;rateLimitCount\&quot;:\&quot;1\&quot;}</para>
                /// </summary>
                [NameInMap("SerializedParams")]
                [Validation(Required=false)]
                public string SerializedParams { get; set; }

                /// <summary>
                /// <para>Trunk name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>小码-公共</para>
                /// </summary>
                [NameInMap("TrunkName")]
                [Validation(Required=false)]
                public string TrunkName { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4BEAB4B-C810-5386-B72A-1A35FF1E6B15</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
