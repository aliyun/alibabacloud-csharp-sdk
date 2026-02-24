// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigurationRecorderResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource monitoring information.</para>
        /// </summary>
        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public GetConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class GetConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
            /// <summary>
            /// <para>The status of resource monitoring. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>REGISTRABLE: Not registered.</para>
            /// </description></item>
            /// <item><description><para>BUILDING: Building.</para>
            /// </description></item>
            /// <item><description><para>REGISTERED: Registered.</para>
            /// </description></item>
            /// <item><description><para>REBUILDING: Rebuilding.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERED</para>
            /// </summary>
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=false)]
            public string ConfigurationRecorderStatus { get; set; }

            /// <summary>
            /// <para>A list of monitored resource types.</para>
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE43696A-B3AF-5E55-9845-11393127E6D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
