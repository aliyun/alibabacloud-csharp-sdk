// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The policy attachment records.</para>
        /// </summary>
        [NameInMap("PolicyAttachments")]
        [Validation(Required=false)]
        public ListPolicyAttachmentsResponseBodyPolicyAttachments PolicyAttachments { get; set; }
        public class ListPolicyAttachmentsResponseBodyPolicyAttachments : TeaModel {
            [NameInMap("PolicyAttachment")]
            [Validation(Required=false)]
            public List<ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment> PolicyAttachment { get; set; }
            public class ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment : TeaModel {
                /// <summary>
                /// <para>The time when the policy was attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// <para>The description of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the policy.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AdministratorAccess</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <para>The type of the policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom: custom policy</description></item>
                /// <item><description>System: system policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The name of the object to which the policy is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:alice@demo.onaliyun.com">alice@demo.onaliyun.com</a></para>
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// <para>The type of the object to which the policy is attached. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IMSUser: RAM user</description></item>
                /// <item><description>IMSGroup: RAM user group</description></item>
                /// <item><description>ServiceRole: RAM role</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IMSUser</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// <para>The ID of the resource group or the ID of the Alibaba Cloud account to which the resource group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-9gLOoK****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
