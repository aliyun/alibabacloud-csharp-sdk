// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateIntegrationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about the alert integration.</para>
        /// </summary>
        [NameInMap("Integration")]
        [Validation(Required=false)]
        public CreateIntegrationResponseBodyIntegration Integration { get; set; }
        public class CreateIntegrationResponseBodyIntegration : TeaModel {
            /// <summary>
            /// <para>Indicates whether alert events are automatically cleared. Default value: true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRecover")]
            [Validation(Required=false)]
            public bool? AutoRecover { get; set; }

            /// <summary>
            /// <para>The description of the alert integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the alert integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("IntegrationId")]
            [Validation(Required=false)]
            public long? IntegrationId { get; set; }

            /// <summary>
            /// <para>The name of the alert integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudMonitor integration</para>
            /// </summary>
            [NameInMap("IntegrationName")]
            [Validation(Required=false)]
            public string IntegrationName { get; set; }

            /// <summary>
            /// <para>The service of the alert integration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CLOUD_MONITOR: CloudMonitor</description></item>
            /// <item><description>LOG_SERVICE: Log Service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_MONITOR</para>
            /// </summary>
            [NameInMap("IntegrationProductType")]
            [Validation(Required=false)]
            public string IntegrationProductType { get; set; }

            /// <summary>
            /// <para>The period of time within which alert events are automatically cleared. Unit: seconds. Default value: 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("RecoverTime")]
            [Validation(Required=false)]
            public long? RecoverTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
