// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListScenarioRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the business monitoring job.
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

        /// <summary>
        /// The scenario where the business monitoring job is used. Valid values:
        /// 
        /// *   `USER-DEFINED`: user-defined. This is the default value.
        /// *   `EDAS-ROLLOUT`: application release in Enterprise Distributed Application Service (EDAS)
        /// *   `OAM-ROLLOUT`: application release based on Open Application Model (OAM)
        /// *   `MSC-CANARY`: canary release based on Microservice Engine (MSE)
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// The code of the business monitoring job. Set this parameter when you know the code of the business monitoring job you want to query.
        /// </summary>
        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

    }

}
