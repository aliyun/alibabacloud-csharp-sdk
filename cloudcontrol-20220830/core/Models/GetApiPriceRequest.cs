// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetApiPriceRequest : TeaModel {
        /// <summary>
        /// <para>The pricing request body, including popCode, popVersion, apiName, and parameters. All calls return a unified pricing envelope. The language parameter specifies the server-side message language, such as en or zh. Target resource operations are not executed for cost-irrelevant or unsupported pricing queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;popCode&quot;:&quot;ecs&quot;,&quot;popVersion&quot;:&quot;2014-05-26&quot;,&quot;apiName&quot;:&quot;CreateDisk&quot;,&quot;parameters&quot;:{&quot;RegionId&quot;:&quot;cn-hangzhou&quot;,&quot;ZoneId&quot;:&quot;cn-hangzhou-i&quot;,&quot;DiskCategory&quot;:&quot;cloud_essd&quot;,&quot;Size&quot;:40},&quot;language&quot;:&quot;zh&quot;}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
