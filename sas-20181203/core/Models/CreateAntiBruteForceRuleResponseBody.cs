// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAntiBruteForceRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the defense rule.</para>
        /// </summary>
        [NameInMap("CreateAntiBruteForceRule")]
        [Validation(Required=false)]
        public CreateAntiBruteForceRuleResponseBodyCreateAntiBruteForceRule CreateAntiBruteForceRule { get; set; }
        public class CreateAntiBruteForceRuleResponseBodyCreateAntiBruteForceRule : TeaModel {
            /// <summary>
            /// <para>The ID of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65778</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D0760E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
