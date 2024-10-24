// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopAttackListResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak QPS of the website.</para>
        /// </summary>
        [NameInMap("AttackList")]
        [Validation(Required=false)]
        public List<DescribeDomainTopAttackListResponseBodyAttackList> AttackList { get; set; }
        public class DescribeDomainTopAttackListResponseBodyAttackList : TeaModel {
            /// <summary>
            /// <para>The attack QPS. Unit: QPS</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Attack")]
            [Validation(Required=false)]
            public long? Attack { get; set; }

            /// <summary>
            /// <para>The number of all QPS, which includes normal and attack QPS. Unit: QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
