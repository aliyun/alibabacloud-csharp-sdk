// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddZooKeeperSaslUserShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: zh (default): Chinese, en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-st21ri2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the cluster to immediately load the SASL users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reload")]
        [Validation(Required=false)]
        public bool? Reload { get; set; }

        /// <summary>
        /// <para>The list of SASL users to add.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SaslUser")]
        [Validation(Required=false)]
        public string SaslUserShrink { get; set; }

    }

}
