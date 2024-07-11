// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationGroupRequest : TeaModel {
        /// <summary>
        /// The application name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the application group in CloudMonitor.
        /// </summary>
        [NameInMap("CmsGroupId")]
        [Validation(Required=false)]
        public string CmsGroupId { get; set; }

        /// <summary>
        /// The ID of the region in which the related sources reside.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeployRegionId")]
        [Validation(Required=false)]
        public string DeployRegionId { get; set; }

        /// <summary>
        /// The description of the application group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The key of the tag. You must set both the ImportTagKey and the ImportTagValue parameters, or leave both of them empty. If you do not set the ImportTagKey and ImportTagValue parameters, the application name is used for this parameter by default.
        /// </summary>
        [NameInMap("ImportTagKey")]
        [Validation(Required=false)]
        public string ImportTagKey { get; set; }

        /// <summary>
        /// The value of the tag. You must set both the ImportTagKey and the ImportTagValue parameters, or leave both of them empty. If you do not set the ImportTagKey and ImportTagValue parameters, the application group name is used for this parameter by default.
        /// </summary>
        [NameInMap("ImportTagValue")]
        [Validation(Required=false)]
        public string ImportTagValue { get; set; }

        /// <summary>
        /// The name of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
