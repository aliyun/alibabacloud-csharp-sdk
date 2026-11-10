// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCloudPermissionTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether users are allowed to apply.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowRequest")]
        [Validation(Required=false)]
        public bool? AllowRequest { get; set; }

        /// <summary>
        /// <para>The applicable scope of the permission template, including the scope type and specified users, groups, or organizational units.</para>
        /// </summary>
        [NameInMap("ApplicableScope")]
        [Validation(Required=false)]
        public UpdateCloudPermissionTemplateRequestApplicableScope ApplicableScope { get; set; }
        public class UpdateCloudPermissionTemplateRequestApplicableScope : TeaModel {
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
            /// <para>The application scope type. Valid values: global and custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The list of account IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token.</para>
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
        /// <para>ac_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>The list of cloud account resources.</para>
        /// </summary>
        [NameInMap("CloudAccountResources")]
        [Validation(Required=false)]
        public List<UpdateCloudPermissionTemplateRequestCloudAccountResources> CloudAccountResources { get; set; }
        public class UpdateCloudPermissionTemplateRequestCloudAccountResources : TeaModel {
            /// <summary>
            /// <para>The cloud account resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>car_01lap4os3aaerckla05vftnsl8edo</para>
            /// </summary>
            [NameInMap("CloudAccountResourceId")]
            [Validation(Required=false)]
            public string CloudAccountResourceId { get; set; }

        }

        /// <summary>
        /// <para>The permission template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateId")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the permission template. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev-default</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateName")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateName { get; set; }

        /// <summary>
        /// <para>The description of the permission template. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_for_test</para>
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
