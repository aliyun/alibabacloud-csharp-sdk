// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventTopAttackTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BECDBF66-91DA-5B40-8B05-0D26541A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TopAttackTypeList")]
        [Validation(Required=false)]
        public List<DescribeRiskEventTopAttackTypeResponseBodyTopAttackTypeList> TopAttackTypeList { get; set; }
        public class DescribeRiskEventTopAttackTypeResponseBodyTopAttackTypeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("AttackCnt")]
            [Validation(Required=false)]
            public long? AttackCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public long? AttackType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public long? ProtectCnt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>47</para>
        /// </summary>
        [NameInMap("TotalAttackCnt")]
        [Validation(Required=false)]
        public long? TotalAttackCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>65</para>
        /// </summary>
        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

    }

}
