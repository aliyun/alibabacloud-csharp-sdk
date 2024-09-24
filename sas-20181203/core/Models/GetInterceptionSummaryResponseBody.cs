// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics.</para>
        /// </summary>
        [NameInMap("InterceptionSummary")]
        [Validation(Required=false)]
        public GetInterceptionSummaryResponseBodyInterceptionSummary InterceptionSummary { get; set; }
        public class GetInterceptionSummaryResponseBodyInterceptionSummary : TeaModel {
            /// <summary>
            /// <para>The number of clusters that are not protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CloseClusterCount")]
            [Validation(Required=false)]
            public int? CloseClusterCount { get; set; }

            /// <summary>
            /// <para>The number of disabled cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CloseRuleCount")]
            [Validation(Required=false)]
            public int? CloseRuleCount { get; set; }

            /// <summary>
            /// <para>The total number of clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// <para>The total number of interception records for the specified cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InterceptionCountInDays")]
            [Validation(Required=false)]
            public int? InterceptionCountInDays { get; set; }

            /// <summary>
            /// <para>The number of clusters that are protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OpenClusterCount")]
            [Validation(Required=false)]
            public int? OpenClusterCount { get; set; }

            /// <summary>
            /// <para>The number of enabled cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public int? OpenRuleCount { get; set; }

            /// <summary>
            /// <para>The number of security risks that are detected in the last 180 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount180Day")]
            [Validation(Required=false)]
            public long? RiskCount180Day { get; set; }

            /// <summary>
            /// <para>The number of security risks that are detected in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount30Day")]
            [Validation(Required=false)]
            public long? RiskCount30Day { get; set; }

            /// <summary>
            /// <para>The number of security risks that are detected in the last 24 hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCountToday")]
            [Validation(Required=false)]
            public long? RiskCountToday { get; set; }

            /// <summary>
            /// <para>The total number of cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

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
