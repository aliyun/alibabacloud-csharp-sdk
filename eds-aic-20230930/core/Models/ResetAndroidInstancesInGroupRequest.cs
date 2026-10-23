// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResetAndroidInstancesInGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip parameter validation. A value of true indicates that parameter validation is skipped. A value of false or no value indicates that parameter validation is performed.</para>
        /// </summary>
        [NameInMap("IgnoreParamValidation")]
        [Validation(Required=false)]
        public bool? IgnoreParamValidation { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The sale mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;Specifies whether to retain property settings during the reset. If this parameter is not specified, property configurations are not retained by default. This parameter takes effect only for cloud phone matrix instances. You can run the wya dump config command to view the details of the retained properties.
        /// &lt;props=&quot;intl&quot;&gt;This parameter is not supported on the international site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SettingResetType")]
        [Validation(Required=false)]
        public int? SettingResetType { get; set; }

        /// <summary>
        /// <para>For instances in a cloud phone matrix, specify this parameter if you need to reduce the storage capacity during the reset. This feature is currently available only to whitelisted users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TargetDataDiskSize")]
        [Validation(Required=false)]
        public int? TargetDataDiskSize { get; set; }

    }

}
