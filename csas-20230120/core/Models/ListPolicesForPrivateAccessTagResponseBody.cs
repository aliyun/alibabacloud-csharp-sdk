// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForPrivateAccessTagResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4D169859-A4F2-5EC8-853B-8447787C0D8A</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>Application</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <para>内网访问策略创建时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-21 14:10:16</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>自定义用户组属性集合。多个自定义用户组属性之间是或的关系，按照合集生效。</para>
                /// </summary>
                [NameInMap("CustomUserAttributes")]
                [Validation(Required=false)]
                public List<ListPolicesForPrivateAccessTagResponseBodyTagsPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
                public class ListPolicesForPrivateAccessTagResponseBodyTagsPolicesCustomUserAttributes : TeaModel {
                    /// <summary>
                    /// <para>用户组的身份源ID。当自定义用户组类型为<b>department</b>时，存在该值。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("IdpId")]
                    [Validation(Required=false)]
                    public int? IdpId { get; set; }

                    /// <summary>
                    /// <para>用户组的关系。取值：</para>
                    /// <list type="bullet">
                    /// <item><description><b>Equal</b>：等于。</description></item>
                    /// <item><description><b>Unequal</b>：不等于。</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Equal</para>
                    /// </summary>
                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                    /// <summary>
                    /// <para>用户组的类型。取值：</para>
                    /// <list type="bullet">
                    /// <item><description><b>username</b>：用户名。</description></item>
                    /// <item><description><b>department</b>：部门。</description></item>
                    /// <item><description><b>email</b>：邮箱。</description></item>
                    /// <item><description><b>telephone</b>：手机。</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>department</para>
                    /// </summary>
                    [NameInMap("UserGroupType")]
                    [Validation(Required=false)]
                    public string UserGroupType { get; set; }

                    /// <summary>
                    /// <para>用户组属性的值。</para>
                    /// <list type="bullet">
                    /// <item><description>当用户组类型为<b>username</b>时，表示用户名的值。长度为1~128个字符，支持中文和大小写英文字母，可包含数字、半角句号（.）、下划线（_）和短划线（-）。</description></item>
                    /// <item><description>当用户组类型为<b>department</b>时，表示部门的值。如：OU=部门1,OU=SASE钉钉。</description></item>
                    /// <item><description>当用户组类型为<b>email</b>时，表示邮箱的值。如：<a href="mailto:username@example.com">username@example.com</a>。</description></item>
                    /// <item><description>当用户组类型为<b>telephone</b>时，表示手机的值。如：13900001234。</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OU=部门1,OU=SASE钉钉</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>private_access_policy_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("PolicyAction")]
                [Validation(Required=false)]
                public string PolicyAction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-policy-867ef4007c8a****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag-b927baf3e592****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
