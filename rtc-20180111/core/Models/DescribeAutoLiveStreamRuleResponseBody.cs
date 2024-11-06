// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAutoLiveStreamRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>069BCB66-CD80-11E8-A82B-A70F78BBDC00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeAutoLiveStreamRuleResponseBodyRules> Rules { get; set; }
        public class DescribeAutoLiveStreamRuleResponseBodyRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com/callBack">http://example.com/callBack</a></para>
            /// </summary>
            [NameInMap("CallBack")]
            [Validation(Required=false)]
            public string CallBack { get; set; }

            [NameInMap("ChannelIdPrefixes")]
            [Validation(Required=false)]
            public List<string> ChannelIdPrefixes { get; set; }

            [NameInMap("ChannelIds")]
            [Validation(Required=false)]
            public List<string> ChannelIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-19T02:53:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rtmp://${domain}/${app}/${stream}</para>
            /// </summary>
            [NameInMap("PlayDomain")]
            [Validation(Required=false)]
            public string PlayDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testRule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
