// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// <para>Member account ID. This parameter is only applicable to multi-account evaluation mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        [NameInMap("EvaluationDomain")]
        [Validation(Required=false)]
        public string EvaluationDomain { get; set; }

        /// <summary>
        /// <para>Filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListEvaluationResultsRequestFilters> Filters { get; set; }
        public class ListEvaluationResultsRequestFilters : TeaModel {
            /// <summary>
            /// <para>Filter condition key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ResourceId: Resource ID.</description></item>
            /// <item><description>ResourceName: Resource name.</description></item>
            /// <item><description>ResourceType: Resource type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>List of filter condition values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>Special evaluation code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>basic (default): Basic model (governance maturity) evaluation.</description></item>
        /// <item><description>ack: Container construction special evaluation.</description></item>
        /// <item><description>ai: Machine learning special evaluation.</description></item>
        /// <item><description>nis: Network service special evaluation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("LensCode")]
        [Validation(Required=false)]
        public string LensCode { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Governance maturity evaluation scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Account (default): Performs single-account governance maturity evaluation, evaluating only the current account.</description></item>
        /// <item><description>ResourceDirectory: Performs multi-account governance maturity evaluation, evaluating all member accounts in the resource directory. Before performing this operation, you must first upgrade to multi-account governance maturity evaluation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceDirectory</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Evaluation snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-bp1r**************</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>Governance topic code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IdentityAndAccessManagement</para>
        /// </summary>
        [NameInMap("TopicCode")]
        [Validation(Required=false)]
        public string TopicCode { get; set; }

    }

}
