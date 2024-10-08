// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceCenterServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The initialization status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The service is being initialized.</description></item>
        /// <item><description>Finished: The service is initialized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("InitialStatus")]
        [Validation(Required=false)]
        public string InitialStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD5F848D-CCDC-5464-93E1-4BA50A4826DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The service is activated.</description></item>
        /// <item><description>Disabled: The service is deactivated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
