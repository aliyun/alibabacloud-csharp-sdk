// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectShrinkRequest : TeaModel {
        [NameInMap("CommonTransferConfig")]
        [Validation(Required=false)]
        public string CommonTransferConfigShrink { get; set; }

        [NameInMap("EnableFullTransfer")]
        [Validation(Required=false)]
        public bool? EnableFullTransfer { get; set; }

        [NameInMap("EnableFullVerify")]
        [Validation(Required=false)]
        public bool? EnableFullVerify { get; set; }

        [NameInMap("EnableIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableIncrTransfer { get; set; }

        [NameInMap("EnableReverseIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableReverseIncrTransfer { get; set; }

        [NameInMap("EnableStructTransfer")]
        [Validation(Required=false)]
        public bool? EnableStructTransfer { get; set; }

        [NameInMap("FullTransferConfig")]
        [Validation(Required=false)]
        public string FullTransferConfigShrink { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncrTransferConfig")]
        [Validation(Required=false)]
        public string IncrTransferConfigShrink { get; set; }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        [NameInMap("ReverseIncrTransferConfig")]
        [Validation(Required=false)]
        public string ReverseIncrTransferConfigShrink { get; set; }

        [NameInMap("SinkEndpointId")]
        [Validation(Required=false)]
        public string SinkEndpointId { get; set; }

        [NameInMap("SourceEndpointId")]
        [Validation(Required=false)]
        public string SourceEndpointId { get; set; }

        [NameInMap("StructTransferConfig")]
        [Validation(Required=false)]
        public string StructTransferConfigShrink { get; set; }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public string TransferMappingShrink { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UseOss")]
        [Validation(Required=false)]
        public bool? UseOss { get; set; }

        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
