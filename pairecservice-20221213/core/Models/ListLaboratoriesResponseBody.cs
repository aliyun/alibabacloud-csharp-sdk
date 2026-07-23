// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListLaboratoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of laboratories.</para>
        /// </summary>
        [NameInMap("Laboratories")]
        [Validation(Required=false)]
        public List<ListLaboratoriesResponseBodyLaboratories> Laboratories { get; set; }
        public class ListLaboratoriesResponseBodyLaboratories : TeaModel {
            /// <summary>
            /// <para>The bucket count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            /// <summary>
            /// <para>The bucketing method.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Uid-UID</c>: Bucketing by UID (default)</para>
            /// </description></item>
            /// <item><description><para><c>UidHash</c>: Bucketing by UID hash</para>
            /// </description></item>
            /// <item><description><para><c>Filter</c>: Bucketing by a filter condition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Filter</para>
            /// </summary>
            [NameInMap("BucketType")]
            [Validation(Required=false)]
            public string BucketType { get; set; }

            /// <summary>
            /// <para>The assigned buckets, specified as numbers or ranges separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3,10-20</para>
            /// </summary>
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            /// <summary>
            /// <para>The crowd ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            /// <summary>
            /// <para>The debug crowd ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            /// <summary>
            /// <para>The debug users, separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1,user2,user3</para>
            /// </summary>
            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            /// <summary>
            /// <para>The laboratory description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The laboratory environment.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Daily</c>: the daily environment</para>
            /// </description></item>
            /// <item><description><para><c>Pre</c>: the pre-production environment</para>
            /// </description></item>
            /// <item><description><para><c>Prod</c>: the production environment</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }

            /// <summary>
            /// <para>The filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>filter=xxx</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// <para>The laboratory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LaboratoryId")]
            [Validation(Required=false)]
            public string LaboratoryId { get; set; }

            /// <summary>
            /// <para>The laboratory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>laboratory1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The laboratory status.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Offline</c>: The laboratory is offline.</para>
            /// </description></item>
            /// <item><description><para><c>Online</c>: The laboratory is online.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The laboratory type.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Base</c>: A base laboratory.</para>
            /// </description></item>
            /// <item><description><para><c>NonBase</c>: A non-base laboratory.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Base</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C0898E5-9220-5443-B2D9-445FF0688215</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of laboratories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
