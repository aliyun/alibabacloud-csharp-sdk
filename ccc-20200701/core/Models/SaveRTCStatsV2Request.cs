// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SaveRTCStatsV2Request : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GeneralInfo")]
        [Validation(Required=false)]
        public string GeneralInfo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GoogAddress")]
        [Validation(Required=false)]
        public string GoogAddress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReceiverReport")]
        [Validation(Required=false)]
        public string ReceiverReport { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SenderReport")]
        [Validation(Required=false)]
        public string SenderReport { get; set; }

    }

}
