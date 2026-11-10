// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCloudPermissionTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether users are allowed to apply for the permission template. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowRequest")]
        [Validation(Required=false)]
        public bool? AllowRequest { get; set; }

        /// <summary>
        /// <para>The applicable scope of the permission template, including the scope type and the specified users, groups, or organizational units.</para>
        /// </summary>
        [NameInMap("ApplicableScope")]
        [Validation(Required=false)]
        public CreateCloudPermissionTemplateRequestApplicableScope ApplicableScope { get; set; }
        public class CreateCloudPermissionTemplateRequestApplicableScope : TeaModel {
            /// <summary>
            /// <para>The list of group IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_d6sbsusdfa4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            /// <summary>
            /// <para>The list of organizational unit IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_d6sbsuudfgf4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> OrganizationalUnitIds { get; set; }

            /// <summary>
            /// <para>The type of the applicable scope. Valid values: global and custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The list of user IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate the value from your client to ensure that the value is unique across different requests. The client token supports only ASCII characters and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cloud account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_01kmegjc11qa1txxxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>The list of cloud account resource policies.</para>
        /// </summary>
        [NameInMap("CloudAccountResources")]
        [Validation(Required=false)]
        public List<CreateCloudPermissionTemplateRequestCloudAccountResources> CloudAccountResources { get; set; }
        public class CreateCloudPermissionTemplateRequestCloudAccountResources : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud account resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>car_01l8a1l906kqtkacdfp5dxxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountResourceId")]
            [Validation(Required=false)]
            public string CloudAccountResourceId { get; set; }

        }

        /// <summary>
        /// <para>The name of the permission template. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateName")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateName { get; set; }

        /// <summary>
        /// <para>The usage type of the permission template. Valid values: user (privilege escalation for human users) and application (privilege escalation for M2M applications). Default value: user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateUsageType")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateUsageType { get; set; }

        /// <summary>
        /// <para>The description of the permission template. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
