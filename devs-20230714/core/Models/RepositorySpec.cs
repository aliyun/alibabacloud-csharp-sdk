// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class RepositorySpec : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://github.com/DDofDD/start-springboot-lfgy.git">https://github.com/DDofDD/start-springboot-lfgy.git</a></para>
        /// </summary>
        [NameInMap("cloneUrl")]
        [Validation(Required=false)]
        public string CloneUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>awesome-connection</para>
        /// </summary>
        [NameInMap("connectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-repo-name</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>312649</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-org-name</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>github</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://github.com/my-org-name/my-repo-name">https://github.com/my-org-name/my-repo-name</a></para>
        /// </summary>
        [NameInMap("webUrl")]
        [Validation(Required=false)]
        public string WebUrl { get; set; }

    }

}
