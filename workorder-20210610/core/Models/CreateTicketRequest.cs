// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the problem category. You can obtain the returned value from the ListCategories operation by using the CategoryId parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7161</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Submit the Alibaba Cloud UID of the account, which is required for the MPK virtual market scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1289427240739141</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The description of the ticket. Only pure text format is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Why ECS backup failed?</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><a href="mailto:sdahkjdshga@qq.com">sdahkjdshga@qq.com</a></para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:163@163.com">163@163.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The list of attachment names, GetAttachmentUploadUrl the ObjectKey field returned by the interface.</para>
        /// </summary>
        [NameInMap("FileNameList")]
        [Validation(Required=false)]
        public List<string> FileNameList { get; set; }

        /// <summary>
        /// <para>Sensitive information</para>
        /// </summary>
        [NameInMap("SecretInfo")]
        [Validation(Required=false)]
        public CreateTicketRequestSecretInfo SecretInfo { get; set; }
        public class CreateTicketRequestSecretInfo : TeaModel {
            /// <summary>
            /// <para>Sensitive information-text content</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID:330102xxxxxx</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Sensitive Information-Attachment Name List</para>
            /// </summary>
            [NameInMap("FileNameList")]
            [Validation(Required=false)]
            public List<string> FileNameList { get; set; }

        }

        /// <summary>
        /// <para>Enumeration value, 1 for general problem, 2 for urgent problem</para>
        /// <para>Enumeration values:</para>
        /// <list type="bullet">
        /// <item><description>1: regular.</description></item>
        /// <item><description>2: emergency.</description></item>
        /// </list>
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
        /// <para>Why ECS backup failed?</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
