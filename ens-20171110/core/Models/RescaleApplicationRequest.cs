// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can obtain this value by calling the ListApplications operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d9143f0</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The level of the scaling region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AreaIspCode: region ISP.</description></item>
        /// <item><description>RegionId: edge zone.</description></item>
        /// <item><description>InstanceId: instance. Scale-out indicates resource hosting. Scale-in indicates resource release.</description></item>
        /// </list>
        /// <para>Default value: AreaIspCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionId</para>
        /// </summary>
        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        /// <summary>
        /// <para>The scaling action for resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Add: Provisions new resources.</description></item>
        /// <item><description>Del: Releases resources.</description></item>
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
        /// <para>The scaling resource requirements. The value is a string in JSON array format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;regionCode\&quot;: \&quot;cn-wuxi-telecom_unicom_cmcc-3\&quot;,    \&quot;ispCode\&quot;: \&quot;telecom\&quot;,    \&quot;count\&quot;: 2	},{    \&quot;regionCode\&quot;: \&quot;cn-shanghai-cmcc\&quot;,    \&quot;count\&quot;: 4	}]</para>
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

        /// <summary>
        /// <para>The timeout period for asynchronous scaling, in seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The application deployment version for new resources. This parameter takes effect only when resources are added. Default value: the stable version number of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

    }

}
