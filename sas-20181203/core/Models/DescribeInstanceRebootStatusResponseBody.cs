// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceRebootStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the status information about the servers that you restart.</para>
        /// </summary>
        [NameInMap("RebootStatuses")]
        [Validation(Required=false)]
        public List<DescribeInstanceRebootStatusResponseBodyRebootStatuses> RebootStatuses { get; set; }
        public class DescribeInstanceRebootStatusResponseBodyRebootStatuses : TeaModel {
            /// <summary>
            /// <para>The error code that is returned when the server failed to be restarted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10001</b>: The restart command failed to be sent.</description></item>
            /// <item><description><b>10002</b>: The restart operation failed.</description></item>
            /// <item><description><b>10003</b>: A timeout error occurs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The message that is returned when the server failed to be restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>push failed</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The status of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The server is being restarted.</description></item>
            /// <item><description><b>1</b>: The server is restarted.</description></item>
            /// <item><description><b>2</b>: The server failed to be restarted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RebootStatus")]
            [Validation(Required=false)]
            public int? RebootStatus { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b59c2d6-0967-46e3-ad7b-152227c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BD95679-D63A-4151-97D0-188432F4A57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
