// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListZonesRequest : TeaModel {
        /// <summary>
        /// <para>The target gateway edition for querying zones. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Professional: standard gateway. This is the default value.</description></item>
        /// <item><description>ServerlessV2: API multi-tenant Serverless V2.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, Professional is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ServerlessV2</para>
        /// </summary>
        [NameInMap("gatewayEdition")]
        [Validation(Required=false)]
        public string GatewayEdition { get; set; }

    }

}
