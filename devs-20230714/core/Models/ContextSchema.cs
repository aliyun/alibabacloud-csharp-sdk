// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ContextSchema : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://git-scm.com/">git</a> address for <a href="https://git-scm.com/docs/git-clone">git clone</a>.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:git@gitlab.alibaba-inc.com">git@gitlab.alibaba-inc.com</a>:serverless/lambda.git</para>
        /// </summary>
        [NameInMap("hint")]
        [Validation(Required=false)]
        public string Hint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gitRepoUrl</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
