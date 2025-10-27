// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserIPSWhitelistResponseBody : TeaModel {
        [NameInMap("Ipv6Whitelists")]
        [Validation(Required=false)]
        public List<DescribeUserIPSWhitelistResponseBodyIpv6Whitelists> Ipv6Whitelists { get; set; }
        public class DescribeUserIPSWhitelistResponseBodyIpv6Whitelists : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2408:400a:81a:7900:a77d:ea36:fcbf:de40/128</para>
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F788A5-6A47-5EA9-AC30-CA4DB98AD520</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeUserIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeUserIPSWhitelistResponseBodyWhitelists : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.10.200.4/32,10.10.200.25/32</para>
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

    }

}
