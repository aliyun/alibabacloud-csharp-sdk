// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateScenarioRequest : TeaModel {
        /// <summary>
        /// The description of the business scenario.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the business scenario.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// The name of the business scenario.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScenarioName")]
        [Validation(Required=false)]
        public string ScenarioName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > : To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
