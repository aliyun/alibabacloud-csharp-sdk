// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnFullDomainsBlockIPHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <para>The value of Code is not 0 in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>The format of the IP address is invalid.</description></item>
        /// <item><description>The format of the time is invalid.</description></item>
        /// <item><description>Other abnormal scenarios</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The description of the status returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The result of the operation.</para>
        /// </summary>
        [NameInMap("IPBlockInfo")]
        [Validation(Required=false)]
        public List<DescribeDcdnFullDomainsBlockIPHistoryResponseBodyIPBlockInfo> IPBlockInfo { get; set; }
        public class DescribeDcdnFullDomainsBlockIPHistoryResponseBodyIPBlockInfo : TeaModel {
            /// <summary>
            /// <para>The blocked IP address or CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.XXX.XXX.0~1.XXX.XXX.255</para>
            /// </summary>
            [NameInMap("BlockIP")]
            [Validation(Required=false)]
            public string BlockIP { get; set; }

            /// <summary>
            /// <para>The delivery time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-24 18:49:37</para>
            /// </summary>
            [NameInMap("DeliverTime")]
            [Validation(Required=false)]
            public string DeliverTime { get; set; }

            /// <summary>
            /// <para>The delivery status.</para>
            /// <list type="bullet">
            /// <item><description>Success</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13A2B792-9212-1CC9-8525-59EBEF3FFE01</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
