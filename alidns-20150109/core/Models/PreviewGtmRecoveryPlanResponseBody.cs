// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class PreviewGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The returned preview information of the disaster recovery plan.
        /// </summary>
        [NameInMap("Previews")]
        [Validation(Required=false)]
        public PreviewGtmRecoveryPlanResponseBodyPreviews Previews { get; set; }
        public class PreviewGtmRecoveryPlanResponseBodyPreviews : TeaModel {
            [NameInMap("Preview")]
            [Validation(Required=false)]
            public List<PreviewGtmRecoveryPlanResponseBodyPreviewsPreview> Preview { get; set; }
            public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreview : TeaModel {
                /// <summary>
                /// The ID of the GTM instance to which the previewed disaster recovery plan belongs.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the GTM instance to which the previewed disaster recovery plan belongs.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The returned information of the switching policies for address pools.
                /// </summary>
                [NameInMap("SwitchInfos")]
                [Validation(Required=false)]
                public PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfos SwitchInfos { get; set; }
                public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfos : TeaModel {
                    [NameInMap("SwitchInfo")]
                    [Validation(Required=false)]
                    public List<PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfosSwitchInfo> SwitchInfo { get; set; }
                    public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfosSwitchInfo : TeaModel {
                        /// <summary>
                        /// The formatted message content.
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// The name of the switching policy for address pools.
                        /// </summary>
                        [NameInMap("StrategyName")]
                        [Validation(Required=false)]
                        public string StrategyName { get; set; }

                    }

                }

                /// <summary>
                /// The user\\"s domain name or domain name list.
                /// </summary>
                [NameInMap("UserDomainName")]
                [Validation(Required=false)]
                public string UserDomainName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned on all pages.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
