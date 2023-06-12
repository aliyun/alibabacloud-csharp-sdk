// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForPrivateAccessTagResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPolicesForPrivateAccessTagResponseBodyTags> Tags { get; set; }
        public class ListPolicesForPrivateAccessTagResponseBodyTags : TeaModel {
            [NameInMap("Polices")]
            [Validation(Required=false)]
            public List<ListPolicesForPrivateAccessTagResponseBodyTagsPolices> Polices { get; set; }
            public class ListPolicesForPrivateAccessTagResponseBodyTagsPolices : TeaModel {
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// 内网访问策略创建时间。
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 自定义用户组属性集合。多个自定义用户组属性之间是或的关系，按照合集生效。
                /// </summary>
                [NameInMap("CustomUserAttributes")]
                [Validation(Required=false)]
                public List<ListPolicesForPrivateAccessTagResponseBodyTagsPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
                public class ListPolicesForPrivateAccessTagResponseBodyTagsPolicesCustomUserAttributes : TeaModel {
                    /// <summary>
                    /// 用户组的身份源ID。当自定义用户组类型为**department**时，存在该值。
                    /// </summary>
                    [NameInMap("IdpId")]
                    [Validation(Required=false)]
                    public int? IdpId { get; set; }

                    /// <summary>
                    /// 用户组的关系。取值：
                    /// - **Equal**：等于。
                    /// - **Unequal**：不等于。
                    /// </summary>
                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                    /// <summary>
                    /// 用户组的类型。取值：
                    /// - **username**：用户名。
                    /// - **department**：部门。
                    /// - **email**：邮箱。
                    /// - **telephone**：手机。
                    /// </summary>
                    [NameInMap("UserGroupType")]
                    [Validation(Required=false)]
                    public string UserGroupType { get; set; }

                    /// <summary>
                    /// 用户组属性的值。
                    /// - 当用户组类型为**username**时，表示用户名的值。长度为1~128个字符，支持中文和大小写英文字母，可包含数字、半角句号（.）、下划线（_）和短划线（-）。
                    /// - 当用户组类型为**department**时，表示部门的值。如：OU=部门1,OU=SASE钉钉。
                    /// - 当用户组类型为**email**时，表示邮箱的值。如：username@example.com。
                    /// - 当用户组类型为**telephone**时，表示手机的值。如：13900001234。
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PolicyAction")]
                [Validation(Required=false)]
                public string PolicyAction { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

            }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
