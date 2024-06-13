// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoResourceOptimizeRulesAsyncRequest : TeaModel {
        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// The database instance IDs.
        /// 
        /// >  Set this parameter to a JSON array that consists of multiple instance IDs. Separate instance IDs with commas (,). Example: `[\\"Instance ID1\\", \\"Instance ID2\\"]`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The ID of the asynchronous request.
        /// 
        /// >  Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of **ResultId** returned in the response to re-initiate the call until the value of **isFinish** is **true**.**** In this case, you must call this operation at least twice.
        /// </summary>
        [NameInMap("ResultId")]
        [Validation(Required=false)]
        public string ResultId { get; set; }

        /// <summary>
        /// The fragmentation rate that triggers automatic fragment recycling of a single physical table. Valid values: **0.10** to **0.99**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableFragmentationRatio")]
        [Validation(Required=false)]
        public double? TableFragmentationRatio { get; set; }

        /// <summary>
        /// The minimum storage usage that triggers automatic fragment recycling of a single physical table. Valid values: **5** to **100**. Unit: GB.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableSpaceSize")]
        [Validation(Required=false)]
        public double? TableSpaceSize { get; set; }

    }

}
