// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCreditResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the security credit score of the current Alibaba Cloud account in the specified region.</para>
        /// </summary>
        [NameInMap("DdosCredit")]
        [Validation(Required=false)]
        public DescribeDdosCreditResponseBodyDdosCredit DdosCredit { get; set; }
        public class DescribeDdosCreditResponseBodyDdosCredit : TeaModel {
            /// <summary>
            /// <para>The time period after which blackhole filtering is automatically deactivated in the specified region. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("BlackholeTime")]
            [Validation(Required=false)]
            public int? BlackholeTime { get; set; }

            /// <summary>
            /// <para>The security credit score. The full score is <b>1000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The security credit level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>A</b>: outstanding</description></item>
            /// <item><description><b>B</b>: excellent</description></item>
            /// <item><description><b>C</b>: good</description></item>
            /// <item><description><b>D</b>: average</description></item>
            /// <item><description><b>E</b>: poor</description></item>
            /// <item><description><b>F</b>: poorer</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>D</para>
            /// </summary>
            [NameInMap("ScoreLevel")]
            [Validation(Required=false)]
            public string ScoreLevel { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1F7BD73-8E9D-58D9-8658-CFC97112C641</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
