// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetWhatsappHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWhatsappHealthStatusResponseBodyData Data { get; set; }
        public class GetWhatsappHealthStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the messages can be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("CanSendMessage")]
            [Validation(Required=false)]
            public string CanSendMessage { get; set; }

            /// <summary>
            /// <para>The queried entities.</para>
            /// </summary>
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<GetWhatsappHealthStatusResponseBodyDataEntities> Entities { get; set; }
            public class GetWhatsappHealthStatusResponseBodyDataEntities : TeaModel {
                /// <summary>
                /// <para>The Business Manager ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3992****</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                /// <summary>
                /// <para>Indicates whether the messages can be sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("CanSendMessage")]
                [Validation(Required=false)]
                public string CanSendMessage { get; set; }

                /// <summary>
                /// <para>The entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHONE_NUMBER</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The reasons why the messages failed to be sent.</para>
                /// </summary>
                [NameInMap("Errors")]
                [Validation(Required=false)]
                public List<GetWhatsappHealthStatusResponseBodyDataEntitiesErrors> Errors { get; set; }
                public class GetWhatsappHealthStatusResponseBodyDataEntitiesErrors : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>141006</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The description of the error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is an error with the payment method.</para>
                    /// </summary>
                    [NameInMap("ErrorDescription")]
                    [Validation(Required=false)]
                    public string ErrorDescription { get; set; }

                    /// <summary>
                    /// <para>The possible solution to the error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There was an error with your payment method. Please add a new payment method to the account.</para>
                    /// </summary>
                    [NameInMap("PossibleSolution")]
                    [Validation(Required=false)]
                    public string PossibleSolution { get; set; }

                }

                /// <summary>
                /// <para>The template language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>en</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The phone number to which the messages are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86138****</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>The template code. This parameter is returned when the NodeType parameter is set to <b>template</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>939928****</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

                /// <summary>
                /// <para>The WABA ID. You can view the WABA ID in the Chat App Message Service console after you create the WABA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39939***</para>
                /// </summary>
                [NameInMap("WabaId")]
                [Validation(Required=false)]
                public string WabaId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAC72B08-3327-33EF-BEDC-8EC3E83A6575</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
