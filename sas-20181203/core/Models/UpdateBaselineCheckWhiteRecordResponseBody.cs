// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateBaselineCheckWhiteRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateBaselineCheckWhiteRecordResponseBodyData Data { get; set; }
        public class UpdateBaselineCheckWhiteRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The reason for adding the item to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ignore for now</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The ID of the whitelist record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: Server</description></item>
            /// <item><description><b>agentless</b>: agentless</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The target added to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOST_BASELINE_WHITE_LIST_23</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The type of the target to which the whitelist applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>all_instance</b>: All servers</description></item>
            /// <item><description><b>instance</b>: Specified servers</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
