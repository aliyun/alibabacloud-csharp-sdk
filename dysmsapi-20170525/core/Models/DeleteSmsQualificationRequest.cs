// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class DeleteSmsQualificationRequest : TeaModel {
        /// <summary>
        /// <para>The review ticket ID. You can obtain the qualification and its corresponding review ticket ID under the current account by calling the <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a> operation, or on the <a href="https://dysms.console.aliyun.com/domestic/text/qualification">Qualification Management</a> page of Domestic Messages in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The qualification ID, which is the ID returned when you <a href="~~SubmitSmsQualification~~">apply for a qualification</a>. You can obtain the qualification ID under the current account by calling the <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a> operation, or on the <a href="https://dysms.console.aliyun.com/domestic/text/qualification">Qualification Management</a> page of Domestic Messages in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000****</para>
        /// </summary>
        [NameInMap("QualificationGroupId")]
        [Validation(Required=false)]
        public long? QualificationGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
