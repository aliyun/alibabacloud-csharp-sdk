// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRatelimitCharacteristics : TeaModel {
        /// <summary>
        /// <para>The details of logical databases.</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRatelimitCharacteristicsCriteria> Criteria { get; set; }
        public class WafRatelimitCharacteristicsCriteria : TeaModel {
            /// <summary>
            /// <para>The details of logical databases.</para>
            /// </summary>
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public List<WafRatelimitCharacteristicsCriteriaCriteria> Criteria { get; set; }
            public class WafRatelimitCharacteristicsCriteriaCriteria : TeaModel {
                /// <summary>
                /// <para>The details of logical databases.</para>
                /// </summary>
                [NameInMap("Criteria")]
                [Validation(Required=false)]
                public List<WafRatelimitCharacteristicsCriteriaCriteriaCriteria> Criteria { get; set; }
                public class WafRatelimitCharacteristicsCriteriaCriteriaCriteria : TeaModel {
                    /// <summary>
                    /// <para>The matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip.src</para>
                    /// </summary>
                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                }

                /// <summary>
                /// <para>The logical judgment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>and</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public string Logic { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip.src</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

            }

            /// <summary>
            /// <para>The logical judgment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public string Logic { get; set; }

            /// <summary>
            /// <para>The matching type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip.src</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

        }

        /// <summary>
        /// <para>The logical judgment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        /// <summary>
        /// <para>The matching type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

    }

}
