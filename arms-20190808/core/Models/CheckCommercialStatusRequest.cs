// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CheckCommercialStatusRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. Default value: ap-southeast-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sub-product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>apm: Application Monitoring</description></item>
        /// <item><description>rum: Real User Monitoring</description></item>
        /// <item><description>prometheus: Managed Service for Prometheus</description></item>
        /// <item><description>xtrace: Managed Service for OpenTelemetry</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
