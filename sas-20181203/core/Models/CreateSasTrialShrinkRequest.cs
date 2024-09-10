// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSasTrialShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether the request is redirected from the Elastic Compute Service (ECS) console. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("FromEcs")]
        [Validation(Required=false)]
        public bool? FromEcs { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The reason why you apply for the trial. You must specify the reason for the second trial.
        /// </summary>
        [NameInMap("RequestForm")]
        [Validation(Required=false)]
        public string RequestFormShrink { get; set; }

        /// <summary>
        /// The trial type. Valid values:
        /// 
        /// *   **0**: trial prohibited
        /// *   **1**: first trial
        /// *   **2**: second trial
        /// 
        /// >  You can call the [GetCanTrySas](https://help.aliyun.com/document_detail/2623574.html) operation to obtain the trial type. You can start a trial only if this parameter is not set to 0.
        /// </summary>
        [NameInMap("TryType")]
        [Validation(Required=false)]
        public int? TryType { get; set; }

        /// <summary>
        /// The trial edition. Valid values:
        /// 
        /// *   **3**: Enterprise
        /// *   **7**: Ultimate
        /// 
        /// >  You can call the [GetCanTrySas](https://help.aliyun.com/document_detail/2623574.html) operation to obtain the trial edition.
        /// </summary>
        [NameInMap("TryVersion")]
        [Validation(Required=false)]
        public int? TryVersion { get; set; }

    }

}
