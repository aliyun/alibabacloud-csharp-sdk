// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateGrafanaWorkspaceRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The description of the workspace
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GrafanaVersion")]
        [Validation(Required=false)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// The edition.
        /// 
        /// **Valid values:**
        /// 
        /// *   standard: `Beta Edition or Standard Edition`
        /// *   personal_edition: Developer Edition
        /// *   experts_edition: Pro Edition
        /// *   advanced_edition: Advanced Edition
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GrafanaWorkspaceEdition")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceEdition { get; set; }

        /// <summary>
        /// The name of the Grafana workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GrafanaWorkspaceName")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceName { get; set; }

        /// <summary>
        /// The password of the workspace. The password must be 8 to 30 characters in length. It must include at least three of the following characters types: uppercase letter, lowercase letter, digit, and special character. Special characters include () \\" ~ ! @ # $ % ^ & \\* - _ + =.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateGrafanaWorkspaceRequestTags> Tags { get; set; }
        public class CreateGrafanaWorkspaceRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
