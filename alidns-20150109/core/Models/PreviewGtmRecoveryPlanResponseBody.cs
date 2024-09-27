// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class PreviewGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The returned preview information of the disaster recovery plan.</para>
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
                /// <para>The ID of the GTM instance to which the previewed disaster recovery plan belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance-example</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the GTM instance to which the previewed disaster recovery plan belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name-example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The returned information of the switching policies for address pools.</para>
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
                        /// <para>The formatted message content.</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The name of the switching policy for address pools.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>strategy-name-example-1</para>
                        /// </summary>
                        [NameInMap("StrategyName")]
                        [Validation(Required=false)]
                        public string StrategyName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The user\&quot;s domain name or domain name list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.yyy.com</para>
                /// </summary>
                [NameInMap("UserDomainName")]
                [Validation(Required=false)]
                public string UserDomainName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>853805EA-3D47-47D5-9A1A-A45C24313ABD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned on all pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
