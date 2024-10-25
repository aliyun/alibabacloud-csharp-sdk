// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can query the application ID by calling the ListApplications operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d9143f0</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The level of resource scaling. The value must be of the enumerated data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AreaIspCode (default): scales resources based on the Internet service provider (ISP).</description></item>
        /// <item><description>RegionId: scales resources based on the edge node.</description></item>
        /// <item><description>InstanceId: scales resources based on the instance ID. Resource scale-out specifies resource hosting and scale-in specifies resource release.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RegionId</para>
        /// </summary>
        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        /// <summary>
        /// <para>The scaling operation. The value must be of the enumerated data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Add: adds new resources.</description></item>
        /// <item><description>Del: releases resources.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Add</para>
        /// </summary>
        [NameInMap("RescaleType")]
        [Validation(Required=false)]
        public string RescaleType { get; set; }

        /// <summary>
        /// <para>The required resources. The value must be a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;regionCode\&quot;: \&quot;cn-wuxi-telecom_unicom_cmcc-3\&quot;,    \&quot;ispCode\&quot;: \&quot;telecom\&quot;,    \&quot;count\&quot;: 2	},{    \&quot;regionCode\&quot;: \&quot;cn-shanghai-cmcc\&quot;,    \&quot;count\&quot;: 4	}]</para>
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

        /// <summary>
        /// <para>The timeout period for asynchronous scaling. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The version number of the application deployment package. By default, the stable version number is used. This parameter takes effect only when you perform resource scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

    }

}
