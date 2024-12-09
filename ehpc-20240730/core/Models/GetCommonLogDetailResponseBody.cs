// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetCommonLogDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The action name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateCluster</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-abc***</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The information about the logs.</para>
        /// </summary>
        [NameInMap("LogDetail")]
        [Validation(Required=false)]
        public List<GetCommonLogDetailResponseBodyLogDetail> LogDetail { get; set; }
        public class GetCommonLogDetailResponseBodyLogDetail : TeaModel {
            /// <summary>
            /// <para>The stage name of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigNetwork</para>
            /// </summary>
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

            /// <summary>
            /// <para>The information about the log stages.</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<GetCommonLogDetailResponseBodyLogDetailStages> Stages { get; set; }
            public class GetCommonLogDetailResponseBodyLogDetailStages : TeaModel {
                /// <summary>
                /// <para>The log level.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ERROR</description></item>
                /// <item><description>INFO</description></item>
                /// <item><description>WARN</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

                /// <summary>
                /// <para>The output message of the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully created security group sg-bcd***</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The method involved in the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateSecurityGroup</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The request ID associated with the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The action state involved in the log. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>InProgress: The action is being performed.</description></item>
                /// <item><description>Finished: The action is completed.</description></item>
                /// <item><description>Failed: The action failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The resource involved in the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bcd***</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The time when the log was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-22 14:21:54</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The log type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The account ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239***</para>
        /// </summary>
        [NameInMap("OperatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>464E9919-D04F-4D1D-B375-15989492****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137***</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
