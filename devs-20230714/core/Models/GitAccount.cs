// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class GitAccount : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://gitee.com/assets/no_portrait.png">https://gitee.com/assets/no_portrait.png</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your_displayname</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your_username</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://gitlab.com">https://gitlab.com</a></para>
        /// </summary>
        [NameInMap("uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
