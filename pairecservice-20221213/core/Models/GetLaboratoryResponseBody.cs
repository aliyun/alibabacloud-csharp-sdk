// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetLaboratoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BucketCount")]
        [Validation(Required=false)]
        public int? BucketCount { get; set; }

        /// <summary>
        /// <para>The bucketing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uid: UID bucketing (default).</description></item>
        /// <item><description>UidHash: UID hashing.</description></item>
        /// <item><description>Filter: Filter condition bucketing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Filter</para>
        /// </summary>
        [NameInMap("BucketType")]
        [Validation(Required=false)]
        public string BucketType { get; set; }

        /// <summary>
        /// <para>The assigned bucket numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,10-20</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <para>The ID of the crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CrowdId")]
        [Validation(Required=false)]
        public string CrowdId { get; set; }

        /// <summary>
        /// <para>The ID of the debug crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>The debug users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1,user2,user3</para>
        /// </summary>
        [NameInMap("DebugUsers")]
        [Validation(Required=false)]
        public string DebugUsers { get; set; }

        /// <summary>
        /// <para>The description of the laboratory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The runtime environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: Daily environment.</description></item>
        /// <item><description>Pre: Staging environment.</description></item>
        /// <item><description>Prod: Production environment.</description></item>
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
        /// <para>The name of the laboratory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>laboratory1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C0898E5-9220-5443-B2D9-445FF0688215</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Offline: Not online.</description></item>
        /// <item><description>Online: Online.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Offline</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the laboratory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Base</description></item>
        /// <item><description>NonBase</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
