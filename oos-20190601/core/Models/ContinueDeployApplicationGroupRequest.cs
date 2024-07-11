// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ContinueDeployApplicationGroupRequest : TeaModel {
        /// <summary>
        /// The name of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The deployment information about the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeployParameters")]
        [Validation(Required=false)]
        public string DeployParameters { get; set; }

        /// <summary>
        /// The name of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
