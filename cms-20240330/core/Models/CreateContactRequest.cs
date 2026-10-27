// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateContactRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("imUserIds")]
        [Validation(Required=false)]
        public Dictionary<string, string> ImUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_07</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13012345678</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-cms-5884500827389836-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
