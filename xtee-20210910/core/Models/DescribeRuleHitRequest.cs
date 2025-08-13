// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleHitRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values:</para>
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
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Execution time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752571330000</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public long? RequestTime { get; set; }

        /// <summary>
        /// <para>Rule ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>102059</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>Snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("ruleSnapshotId")]
        [Validation(Required=false)]
        public string RuleSnapshotId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60C97040-D5D5-4906-9522-B9B413730CAA</para>
        /// </summary>
        [NameInMap("sRequestId")]
        [Validation(Required=false)]
        public string SRequestId { get; set; }

    }

}
