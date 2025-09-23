// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeFirewallRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFirewallRulesResponseBodyData Data { get; set; }
        public class DescribeFirewallRulesResponseBodyData : TeaModel {
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<string> RuleList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>84D7DCD2-54F7-5BD2-B055-F5DE9D2B5264</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
