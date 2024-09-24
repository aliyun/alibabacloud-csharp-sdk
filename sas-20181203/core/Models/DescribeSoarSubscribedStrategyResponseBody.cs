// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarSubscribedStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The policies.</para>
        /// </summary>
        [NameInMap("SoarStrategies")]
        [Validation(Required=false)]
        public List<DescribeSoarSubscribedStrategyResponseBodySoarStrategies> SoarStrategies { get; set; }
        public class DescribeSoarSubscribedStrategyResponseBodySoarStrategies : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1276085*****4392</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>strategy_description_01</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The total number of times that the policy is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ExecuteNum")]
            [Validation(Required=false)]
            public string ExecuteNum { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716344106000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652672104000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300063</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>strategy_name01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The execution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>runmode_TRIGGER_BY_USER: manually executed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>runmode_TRIGGER_BY_USER</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// <para>The type of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>type_vulfix: vulnerability operations</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>type_vulfix</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
