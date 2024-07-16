// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class UpdateBatchOperateCardsTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BatchOperateCardsTaskId")]
        [Validation(Required=false)]
        public string BatchOperateCardsTaskId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EffectType")]
        [Validation(Required=false)]
        public string EffectType { get; set; }

        [NameInMap("Iccids")]
        [Validation(Required=false)]
        public List<string> Iccids { get; set; }

        [NameInMap("IccidsOssFilePath")]
        [Validation(Required=false)]
        public string IccidsOssFilePath { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

        [NameInMap("WirelessCloudConnectorIds")]
        [Validation(Required=false)]
        public List<string> WirelessCloudConnectorIds { get; set; }

    }

}
