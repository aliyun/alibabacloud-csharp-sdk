// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryInvalidAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>Next request starting position.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95A7D497-F8DD-4834-B81E-C1783236E55F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Records.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryInvalidAddressResponseBodyData Data { get; set; }
        public class QueryInvalidAddressResponseBodyData : TeaModel {
            [NameInMap("mailDetail")]
            [Validation(Required=false)]
            public List<QueryInvalidAddressResponseBodyDataMailDetail> MailDetail { get; set; }
            public class QueryInvalidAddressResponseBodyDataMailDetail : TeaModel {
                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-28T17:11Z</para>
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                /// <summary>
                /// <para>Recipient address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:toaddress@example.com">toaddress@example.com</a></para>
                /// </summary>
                [NameInMap("ToAddress")]
                [Validation(Required=false)]
                public string ToAddress { get; set; }

                /// <summary>
                /// <para>Update time (in timestamp format).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1619601108</para>
                /// </summary>
                [NameInMap("UtcLastUpdateTime")]
                [Validation(Required=false)]
                public long? UtcLastUpdateTime { get; set; }

            }

        }

    }

}
