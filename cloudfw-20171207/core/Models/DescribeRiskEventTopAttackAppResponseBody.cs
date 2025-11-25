// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventTopAttackAppResponseBody : TeaModel {
        [NameInMap("AttackApps")]
        [Validation(Required=false)]
        public List<DescribeRiskEventTopAttackAppResponseBodyAttackApps> AttackApps { get; set; }
        public class DescribeRiskEventTopAttackAppResponseBodyAttackApps : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>live</para>
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AttackCnt")]
            [Validation(Required=false)]
            public int? AttackCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("DropCnt")]
            [Validation(Required=false)]
            public int? DropCnt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C9DDAD29-C6B3-5997-B757-FFB3F1C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
