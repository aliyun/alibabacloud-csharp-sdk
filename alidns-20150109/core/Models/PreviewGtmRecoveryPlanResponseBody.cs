// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class PreviewGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. Default: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: <b>100</b>. Default: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Previews")]
        [Validation(Required=false)]
        public PreviewGtmRecoveryPlanResponseBodyPreviews Previews { get; set; }
        public class PreviewGtmRecoveryPlanResponseBodyPreviews : TeaModel {
            [NameInMap("Preview")]
            [Validation(Required=false)]
            public List<PreviewGtmRecoveryPlanResponseBodyPreviewsPreview> Preview { get; set; }
            public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreview : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SwitchInfos")]
                [Validation(Required=false)]
                public PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfos SwitchInfos { get; set; }
                public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfos : TeaModel {
                    [NameInMap("SwitchInfo")]
                    [Validation(Required=false)]
                    public List<PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfosSwitchInfo> SwitchInfo { get; set; }
                    public class PreviewGtmRecoveryPlanResponseBodyPreviewsPreviewSwitchInfosSwitchInfo : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("StrategyName")]
                        [Validation(Required=false)]
                        public string StrategyName { get; set; }

                    }

                }

                [NameInMap("UserDomainName")]
                [Validation(Required=false)]
                public string UserDomainName { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>853805EA-3D47-47D5-9A1A-A45C24313ABD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
