// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class CreateTicketShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the issue category. Obtain this ID from the ListCategories operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53812</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the account that submits the ticket. This parameter is required for Marketplace reseller scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1289427240739141</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The description of the issue in the ticket. Only plain text is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS backup failed</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The contact email address for the ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:sdahkjdshga@qq.com">sdahkjdshga@qq.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>A list of attachment names. Use the ObjectKey value returned by the GetAttachmentUploadUrl operation.</para>
        /// </summary>
        [NameInMap("FileNameList")]
        [Validation(Required=false)]
        public string FileNameListShrink { get; set; }

        /// <summary>
        /// <para>Sensitive information.</para>
        /// </summary>
        [NameInMap("SecretInfo")]
        [Validation(Required=false)]
        public string SecretInfoShrink { get; set; }

        /// <summary>
        /// <para>An enumeration value. A value of 1 indicates a normal issue. A value of 2 indicates an urgent issue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public int? Severity { get; set; }

        /// <summary>
        /// <para>The title of the ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS backup failed</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
