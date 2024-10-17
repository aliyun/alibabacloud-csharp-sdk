// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSLARulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D1A59F4-EB2B-5D24-80A5-90C446A00DE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of SLA rules.</para>
        /// </summary>
        [NameInMap("SLARuleList")]
        [Validation(Required=false)]
        public ListSLARulesResponseBodySLARuleList SLARuleList { get; set; }
        public class ListSLARulesResponseBodySLARuleList : TeaModel {
            [NameInMap("SLARule")]
            [Validation(Required=false)]
            public List<ListSLARulesResponseBodySLARuleListSLARule> SLARule { get; set; }
            public class ListSLARulesResponseBodySLARuleListSLARule : TeaModel {
                /// <summary>
                /// <para>The ID of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11****</para>
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// <para>The ID of the SLA rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The timeout period. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("IntervalMinutes")]
                [Validation(Required=false)]
                public int? IntervalMinutes { get; set; }

                /// <summary>
                /// <para>The ID of the task node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: an SLA rule for a task flow</description></item>
                /// <item><description><b>1</b>: an SLA rule for a task node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public int? RuleType { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
