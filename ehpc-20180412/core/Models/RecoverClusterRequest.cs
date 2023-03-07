// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class RecoverClusterRequest : TeaModel {
        /// <summary>
        /// The service type of the domain account. Valid values:
        /// 
        /// *   nis
        /// *   ldap
        /// 
        /// Default value: nis
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The version of the E-HPC client. The default value is the latest version of the client.
        /// 
        /// You can call the [ListCurrentClientVersion](~~87223~~) operation to query the current version of the E-HPC client.
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// The ID of the cluster. The cluster must be in the Exception state.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID and status.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the image.
        /// 
        /// You can call the [ListImages](~~87213~~) and [ListCustomImages](~~87215~~) operations to query the images that are supported by E-HPC.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   system: public image
        /// *   self: custom image
        /// *   others: shared image
        /// 
        /// Default value: system
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The image tag of the operating system.
        /// 
        /// You can call the [ListImages](~~87213~~) and [ListCustomImages](~~87215~~) operations to query the image tags supported by Elastic High Performance Computing (E-HPC).
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        /// <summary>
        /// The type of the scheduler. Valid values:
        /// 
        /// *   pbs
        /// *   slurm
        /// *   opengridscheduler
        /// *   deadline
        /// 
        /// Default value: pbs
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

    }

}
