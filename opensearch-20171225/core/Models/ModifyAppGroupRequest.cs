// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyAppGroupRequest : TeaModel {
        /// <summary>
        /// The online version of the application.
        /// </summary>
        [NameInMap("currentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the industry. Valid values:
        /// 
        /// *   general: general.
        /// *   ecommerce: e-commerce.
        /// *   education: education.
        /// *   esports: electronic sports.
        /// *   community: content community.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to verify the application before modification. Valid values: true and false.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
