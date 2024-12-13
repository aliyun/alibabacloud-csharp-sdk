// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetSCIMSynchronizationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C086C2F-1C66-57B3-B14E-2C1DA70727CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of SCIM synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("SCIMSynchronizationStatus")]
        [Validation(Required=false)]
        public string SCIMSynchronizationStatus { get; set; }

    }

}
