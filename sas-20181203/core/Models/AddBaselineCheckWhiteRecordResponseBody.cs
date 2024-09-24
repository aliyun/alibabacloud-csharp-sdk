// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddBaselineCheckWhiteRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddBaselineCheckWhiteRecordResponseBodyData Data { get; set; }
        public class AddBaselineCheckWhiteRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~ListCheckItemWarningSummary~~">ListCheckItemWarningSummary</a> operation to query the IDs of check items.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The reason why the check item is added to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AutoTest</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The ID of the whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>864153</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: server</description></item>
            /// <item><description><b>agentless</b>: agentless detection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The object that is added to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOST_BASELINE_WHITE_LIST_21</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The type of the assets on which the whitelist rule takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>all_instance</b>: all servers</description></item>
            /// <item><description><b>instance</b>: specific servers</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
