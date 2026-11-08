// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMonitoringAgentProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>A status code of 200 indicates success.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>718FEA81-64C3-4F23-8F90-0531F7489FC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The group process information.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public CreateGroupMonitoringAgentProcessResponseBodyResource Resource { get; set; }
        public class CreateGroupMonitoringAgentProcessResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>The group process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7F2B0024-4F21-48B9-A764-211CEC48****</para>
            /// </summary>
            [NameInMap("GroupProcessId")]
            [Validation(Required=false)]
            public string GroupProcessId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
