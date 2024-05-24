// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class RepositorySpec : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cloneUrl")]
        [Validation(Required=false)]
        public string CloneUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("connectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("webUrl")]
        [Validation(Required=false)]
        public string WebUrl { get; set; }

    }

}
