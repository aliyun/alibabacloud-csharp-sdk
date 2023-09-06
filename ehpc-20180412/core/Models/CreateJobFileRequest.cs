// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class CreateJobFileRequest : TeaModel {
        /// <summary>
        /// Indicates whether to use an asynchronous link to submit job files.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The content of the job file. The content is encoded in Base64.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The user to which the job file belongs.
        /// 
        /// You can call the [ListUsers](~~188572~~) operation to query the users of the cluster.
        /// </summary>
        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        /// <summary>
        /// The user password.
        /// </summary>
        [NameInMap("RunasUserPassword")]
        [Validation(Required=false)]
        public string RunasUserPassword { get; set; }

        /// <summary>
        /// The name of the job file.
        /// </summary>
        [NameInMap("TargetFile")]
        [Validation(Required=false)]
        public string TargetFile { get; set; }

    }

}
