// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class RepositorySourceConfig : TeaModel {
        [NameInMap("codeVersion")]
        [Validation(Required=false)]
        public CodeVersionReference CodeVersion { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public EventFilterConfig Filter { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-repository</para>
        /// </summary>
        [NameInMap("repositoryName")]
        [Validation(Required=false)]
        public string RepositoryName { get; set; }

    }

}
