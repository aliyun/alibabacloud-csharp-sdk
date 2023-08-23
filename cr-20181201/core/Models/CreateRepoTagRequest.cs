// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoTagRequest : TeaModel {
        /// <summary>
        /// The source image tag.
        /// </summary>
        [NameInMap("FromTag")]
        [Validation(Required=false)]
        public string FromTag { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// The name of the image repository.
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// The image tag that you want to create.
        /// </summary>
        [NameInMap("ToTag")]
        [Validation(Required=false)]
        public string ToTag { get; set; }

    }

}
