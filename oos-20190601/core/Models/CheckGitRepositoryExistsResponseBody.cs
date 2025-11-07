// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CheckGitRepositoryExistsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RepoExists")]
        [Validation(Required=false)]
        public bool? RepoExists { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AA9FA778-AE4B-55EC-81CC-C46BAF08A166</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
