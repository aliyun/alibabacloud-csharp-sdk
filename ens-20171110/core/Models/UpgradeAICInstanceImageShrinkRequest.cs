// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UpgradeAICInstanceImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AIC image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The IDs of the servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public string ServerIdsShrink { get; set; }

        /// <summary>
        /// <para>The timeout period of the update. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
