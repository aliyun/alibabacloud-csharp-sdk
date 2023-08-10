// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// The details of the application.
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// The status of the Developer API feature. Valid values:
            /// 
            /// *   Enabled: The Developer API feature is enabled.
            /// *   Disabled: The Developer API feature is disabled.
            /// </summary>
            [NameInMap("ApiInvokeStatus")]
            [Validation(Required=false)]
            public string ApiInvokeStatus { get; set; }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The origin of the application. Valid values:
            /// 
            /// *   urn:alibaba:idaas:app:source:template: The application is created based on a template.
            /// *   urn:alibaba:idaas: The application is created based on the standard protocol.
            /// </summary>
            [NameInMap("ApplicationSourceType")]
            [Validation(Required=false)]
            public string ApplicationSourceType { get; set; }

            /// <summary>
            /// The ID of the template based on which the application is created. This parameter is returned only if the application is created based on a template.
            /// </summary>
            [NameInMap("ApplicationTemplateId")]
            [Validation(Required=false)]
            public string ApplicationTemplateId { get; set; }

            /// <summary>
            /// The authorization type of the EIAM application. Valid values:
            /// 
            /// *   authorize_required: Only the user with explicit authorization can access the application.
            /// *   default_all: By default, all users can access the application.
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// The client ID of the application.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The time when the application was created. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The features that are supported by the application. The value is a JSON array. Valid values:
            /// 
            /// *   sso: The application supports SSO.
            /// *   provision: The application supports account synchronization.
            /// *   api_invoke: The application supports custom APIs.
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public string Features { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The URL of the application icon.
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// The service code of the cloud service that manages the application template.
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            /// <summary>
            /// Indicates whether the application template is managed by a cloud service.
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// The type of the single sign-on (SSO) protocol. Valid values:
            /// 
            /// *   saml2: the Security Assertion Markup Language (SAML) 2.0 protocol.
            /// *   oidc: the OpenID Connect (OIDC) protocol.
            /// </summary>
            [NameInMap("SsoType")]
            [Validation(Required=false)]
            public string SsoType { get; set; }

            /// <summary>
            /// The status of the application. Valid values:
            /// 
            /// *   Enabled: The application is enabled.
            /// *   Disabled: The application is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the application was last updated. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
