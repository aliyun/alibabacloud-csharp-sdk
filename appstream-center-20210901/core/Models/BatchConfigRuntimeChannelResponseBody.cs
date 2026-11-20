// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BatchConfigRuntimeChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of batch configuration results. Each channel configuration item corresponds to one result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchConfigRuntimeChannelResponseBodyData> Data { get; set; }
        public class BatchConfigRuntimeChannelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The third-party channel code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk-connector</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error code returned when the configuration fails. This parameter is returned only when Success is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the configuration fails. This parameter is returned only when Success is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The runtime is not found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The agent runtime ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xgads</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <para>Specifies whether the channel configuration item is configured successfully. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The configuration is successful.</description></item>
            /// <item><description>false: The configuration failed. For the cause of the failure, see ErrorCode and Message.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of configuration results, which is the same as the number of configuration items in ChannelConfigs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
