// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetIntegratedServiceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The identity of the cloud service that is integrated with Cloud Config. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eventbridge: EventBridge</description></item>
        /// <item><description>cms: CloudMonitor</description></item>
        /// <item><description>bpstudio: Cloud Architect Design Tools (CADT)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cadt</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
