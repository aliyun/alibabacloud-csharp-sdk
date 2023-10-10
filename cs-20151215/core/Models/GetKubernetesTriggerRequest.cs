// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetKubernetesTriggerRequest : TeaModel {
        /// <summary>
        /// The application name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace name.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The type of trigger. Valid values:
        /// 
        /// *   `deployment`: performs actions on Deployments.
        /// *   `application`: performs actions on applications that are deployed in Application Center.
        /// 
        /// Default value: `deployment`.
        /// 
        /// If you do not set this parameter, triggers are not filtered by type.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The action that the trigger performs. Set the value to redeploy.
        /// 
        /// `redeploy`: redeploys the resources specified by `project_id`.
        /// 
        /// If you do not specify this parameter, triggers are not filtered by action.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
