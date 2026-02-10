// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpgradeGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The destination instance version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
