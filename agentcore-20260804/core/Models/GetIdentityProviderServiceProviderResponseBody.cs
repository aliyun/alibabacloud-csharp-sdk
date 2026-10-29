// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderServiceProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>If the request fails, handle the error based on the HTTP status code and the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>For the result structure, see the response fields of this operation. The response of an asynchronous write operation indicates that the request is accepted, but does not guarantee that the background task is completed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderServiceProviderResponseBodyData Data { get; set; }
        public class GetIdentityProviderServiceProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The SAML assertion consumer service (ACS) URL of the SP. Configure this URL in the external IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sp.example.com/saml/acs">https://sp.example.com/saml/acs</a></para>
            /// </summary>
            [NameInMap("acsUrl")]
            [Validation(Required=false)]
            public string AcsUrl { get; set; }

            /// <summary>
            /// <para>The entity ID of the SP. Configure this ID in the external IdP. This is not the entity ID of the external IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sp.example.com/entity">https://sp.example.com/entity</a></para>
            /// </summary>
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The SP metadata XML for the external IdP to import. You cannot submit this XML as the IdP XML for SAML configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para><EntityDescriptor xmlns="urn:oasis:names:tc:SAML:2.0:metadata" entityID="https://sp.example.com/entity"><SPSSODescriptor protocolSupportEnumeration="urn:oasis:names:tc:SAML:2.0:protocol"><AssertionConsumerService Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST" Location="https://sp.example.com/saml/acs" index="0"/></SPSSODescriptor></EntityDescriptor></para>
            /// </summary>
            [NameInMap("metadataXml")]
            [Validation(Required=false)]
            public string MetadataXml { get; set; }

            /// <summary>
            /// <para>The query parameter is required and only supports the exact value SAML. The response returns SAML.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The processing status of the current request. This is not equivalent to the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request acceptance or error message. For the result of an asynchronous task, check the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID used to associate the current call with troubleshooting. Keep this ID if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A value of true indicates that the current request is processed successfully. For asynchronous writes, you must continue to query the task result.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
