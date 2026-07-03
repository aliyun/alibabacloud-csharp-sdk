// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListAutoDisposeEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of AI-powered automated analysis entities.</para>
        /// </summary>
        [NameInMap("AutoDecisionEntities")]
        [Validation(Required=false)]
        public List<ListAutoDisposeEntitiesResponseBodyAutoDecisionEntities> AutoDecisionEntities { get; set; }
        public class ListAutoDisposeEntitiesResponseBodyAutoDecisionEntities : TeaModel {
            /// <summary>
            /// <para>The alert rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20403189</para>
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public string AlertId { get; set; }

            /// <summary>
            /// <para>The disposal method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ignore</c>: Ignore.</para>
            /// </description></item>
            /// <item><description><para><c>dispose</c>: Playbook-based disposal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dispose</para>
            /// </summary>
            [NameInMap("DisposalMethod")]
            [Validation(Required=false)]
            public string DisposalMethod { get; set; }

            /// <summary>
            /// <para>The disposal ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1ec121479b341a61886dbd2c4ccd*****</para>
            /// </summary>
            [NameInMap("DisposeRecordId")]
            [Validation(Required=false)]
            public string DisposeRecordId { get; set; }

            /// <summary>
            /// <para>The entity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/apps/ext/ka****</para>
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ip</c>: An IP address.</para>
            /// </description></item>
            /// <item><description><para><c>domain</c>: A domain.</para>
            /// </description></item>
            /// <item><description><para><c>process</c>: A process.</para>
            /// </description></item>
            /// <item><description><para><c>file</c>: A file.</para>
            /// </description></item>
            /// <item><description><para><c>host</c>: A host.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>process</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The entity UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>022ed6c601514a370cc9e3acd37a****</para>
            /// </summary>
            [NameInMap("EntityUuid")]
            [Validation(Required=false)]
            public string EntityUuid { get; set; }

            /// <summary>
            /// <para>The playbook UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6fd2b143-e420-4c1b-a118-e764*****</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>The unique identifier (UUID) of the entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0d23f133-22d7-4388-b738-ab******</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The current page number. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. An empty value indicates that all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
