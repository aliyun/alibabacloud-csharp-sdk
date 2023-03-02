// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateMigrationTaskRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The type of the instance. Valid values:
        /// 
        /// *   Nacos-Ans
        /// *   ZooKeeper
        /// *   Eureka
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The address of the source instance node.
        /// </summary>
        [NameInMap("OriginInstanceAddress")]
        [Validation(Required=false)]
        public string OriginInstanceAddress { get; set; }

        /// <summary>
        /// The name of the source instance.
        /// </summary>
        [NameInMap("OriginInstanceName")]
        [Validation(Required=false)]
        public string OriginInstanceName { get; set; }

        /// <summary>
        /// The list of namespaces. This parameter is optional if you want to migrate applications from a Nacos instance.
        /// </summary>
        [NameInMap("OriginInstanceNamespace")]
        [Validation(Required=false)]
        public string OriginInstanceNamespace { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("ProjectDesc")]
        [Validation(Required=false)]
        public string ProjectDesc { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// The name of the destination instance.
        /// </summary>
        [NameInMap("TargetClusterName")]
        [Validation(Required=false)]
        public string TargetClusterName { get; set; }

        /// <summary>
        /// The URL of the destination instance.
        /// </summary>
        [NameInMap("TargetClusterUrl")]
        [Validation(Required=false)]
        public string TargetClusterUrl { get; set; }

        /// <summary>
        /// The ID of the destination instance.
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

    }

}
