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
        public PreviewGtmRecoveryPlanResponseBodyPreviews Previews { get; set; }
        public class PreviewGtmRecoveryPlanResponseBodyPreviews : TeaModel {
            [NameInMap("Preview")]
            [Validation(Required=false)]
            public List<PreviewGtmRecoveryPlanResponseBodyPreviewsPreview> Preview { get; set; }
            public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreview : TeaModel {
                public string InstanceId { get; set; }
                public PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfos SwitchInfos { get; set; }
                public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfos : TeaModel {
                    [NameInMap("SwitchInfo")]
                    [Validation(Required=false)]
                    public List<PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfosSwitchInfo> SwitchInfo { get; set; }
                    public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfosSwitchInfo : TeaModel {
                        [NameInMap("StrategyName")]
                        [Validation(Required=false)]
                        public string StrategyName { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                    }

                }
                public string Name { get; set; }
                public string UserDomainName { get; set; }
            }
        };

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
