// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateKubernetesTriggerRequest : TeaModel {
        /// <summary>
        /// The action that the trigger performs. Set the value to redeploy.
        /// 
        /// `redeploy`: redeploys the resources specified by `project_id`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the trigger project.
        /// 
        /// The name consists of the namespace where the application is deployed and the name of the application. The format is `${namespace}/${name}`.
        /// 
        /// Example: `default/test-app`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The type of trigger. Valid values:
        /// 
        /// *   `deployment`: performs actions on Deployments.
        /// *   `application`: performs actions on applications that are deployed in Application Center.
        /// 
        /// Default value: `deployment`.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
