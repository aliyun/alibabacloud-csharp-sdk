// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class RemoveZooKeeperSaslUserShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned results. Valid values: zh (default): Chinese, en: English.</para>
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
        /// <para>mse_prepaid_public_cn-****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the changes take effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reload")]
        [Validation(Required=false)]
        public bool? Reload { get; set; }

        /// <summary>
        /// <para>The list of usernames to remove.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public string UserNamesShrink { get; set; }

    }

}
