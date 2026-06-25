// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResetAndroidInstancesInGroupRequest : TeaModel {
        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        [NameInMap("IgnoreParamValidation")]
        [Validation(Required=false)]
        public bool? IgnoreParamValidation { get; set; }

        /// <summary>
        /// <para>The sale mode. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;Specifies whether to retain the property settings when you reset the instances. By default, the property settings are not retained. This parameter applies only to cloud phone matrix instances. Run the wya dump config command to view the details of the retained properties.&lt;props=&quot;intl&quot;&gt;This parameter is not supported on the international site (alibabacloud.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SettingResetType")]
        [Validation(Required=false)]
        public int? SettingResetType { get; set; }

    }

}
