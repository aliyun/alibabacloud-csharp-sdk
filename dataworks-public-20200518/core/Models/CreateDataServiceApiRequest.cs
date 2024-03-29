// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDataServiceApiRequest : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("ApiDescription")]
        [Validation(Required=false)]
        public string ApiDescription { get; set; }

        /// <summary>
        /// The format in which the response of the API request is returned. Valid values: 0 and 1. The value 0 indicates the JSON format. The value 1 indicates the XML format. APIs generated in wizard or script mode support the JSON format. APIs generated by registration support the JSON and XML formats.
        /// </summary>
        [NameInMap("ApiMode")]
        [Validation(Required=false)]
        public int? ApiMode { get; set; }

        /// <summary>
        /// The type of the API. Valid values: 0, 1, and 2. The value 0 indicates that the API is generated in wizard mode. The value 1 indicates that the API is generated in script mode. The value 2 indicates that the API is generated by registration.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The ID of the folder used to store the API. The ID of the root folder in a business process is 0. The ID of the folder created by a user must be greater than 0.
        /// </summary>
        [NameInMap("ApiPath")]
        [Validation(Required=false)]
        public string ApiPath { get; set; }

        /// <summary>
        /// The ID of the API.
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public long? FolderId { get; set; }

        /// <summary>
        /// The request method of the API. Valid values: 0, 1, 2, and 3. The value 0 indicates the GET method. The value 1 indicates the POST method. The value 2 indicates the PUT method. The value 3 indicates the DELETE method. APIs generated in wizard or script mode support the GET and POST methods. APIs generated by registration support the GET, POST, PUT, and DELETE methods.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the business process.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The details of the API generated in script mode. For more information, see the ScriptDetails parameter returned by the [GetDataServiceApi](~~174013~~) operation.
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public string Protocols { get; set; }

        /// <summary>
        /// The description of the API.
        /// </summary>
        [NameInMap("RegistrationDetails")]
        [Validation(Required=false)]
        public string RegistrationDetails { get; set; }

        [NameInMap("RequestContentType")]
        [Validation(Required=false)]
        public int? RequestContentType { get; set; }

        /// <summary>
        /// The timeout period of the API request. Unit: milliseconds. Valid values: (0,30000].
        /// </summary>
        [NameInMap("RequestMethod")]
        [Validation(Required=false)]
        public int? RequestMethod { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public long? ResourceGroupId { get; set; }

        /// <summary>
        /// The scope in which the API is visible. Valid values:
        /// 
        /// *   0: The API is visible to all members in the workspace.
        /// *   1: The API is visible only to its owner, and permissions on the API cannot be granted to other members.
        /// </summary>
        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public int? ResponseContentType { get; set; }

        /// <summary>
        /// The path of the API. The path cannot exceed 200 characters in length. The path can contain letters, digits, underscores (\_), and hyphens (-) and must start with a forward slash (/).
        /// </summary>
        [NameInMap("ScriptDetails")]
        [Validation(Required=false)]
        public string ScriptDetails { get; set; }

        [NameInMap("SqlMode")]
        [Validation(Required=false)]
        public long? SqlMode { get; set; }

        /// <summary>
        /// The name of the API. The name must be 4 to 50 characters in length. The name can contain letters, digits, and underscores (\_) and must start with a letter.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// The protocol used by the API. Valid values: 0 and 1. The value 0 indicates HTTP. The value 1 indicates HTTPS. You can specify multiple protocols. Separate them with commas (,).
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The details of the API generated in wizard mode. For more information, see the WizardDetails parameter returned by the [GetDataServiceApi](~~174013~~) operation.
        /// </summary>
        [NameInMap("VisibleRange")]
        [Validation(Required=false)]
        public int? VisibleRange { get; set; }

        /// <summary>
        /// The details of the API generated by registration. For more information, see the RegistrationDetails parameter returned by the [GetDataServiceApi](~~174013~~) operation.
        /// </summary>
        [NameInMap("WizardDetails")]
        [Validation(Required=false)]
        public string WizardDetails { get; set; }

    }

}
