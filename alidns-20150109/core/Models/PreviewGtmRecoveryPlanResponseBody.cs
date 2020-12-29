// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class PreviewGtmRecoveryPlanResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Previews")]
        [Validation(Required=false)]
        public List<PreviewGtmRecoveryPlanResponseBodyPreviews> Previews { get; set; }
        public class PreviewGtmRecoveryPlanResponseBodyPreviews : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SwitchInfos")]
            [Validation(Required=false)]
            public List<PreviewGtmRecoveryPlanResponseBodyPreviewsSwitchInfos> SwitchInfos { get; set; }
            public class PreviewGtmRecoveryPlanResponseBodyPreviewsSwitchInfos : TeaModel {
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserDomainName")]
            [Validation(Required=false)]
            public string UserDomainName { get; set; }

        }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
