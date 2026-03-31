// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigurationRecorderResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the configuration recorder.</para>
        /// </summary>
        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public StartConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class StartConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
            /// <summary>
            /// <para>The status of the configuration recorder. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>REGISTRABLE: The configuration recorder has not been registered.</description></item>
            /// <item><description>BUILDING: The configuration recorder is being deployed.</description></item>
            /// <item><description>REGISTERED: The configuration recorder has been registered.</description></item>
            /// <item><description>REBUILDING: The configuration recorder is being redeployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERED</para>
            /// </summary>
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=false)]
            public string ConfigurationRecorderStatus { get; set; }

            /// <summary>
            /// <para>The types of the resources that are monitored by Cloud Config.</para>
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D994662-6B27-536F-B320-38F4B3D58705</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
