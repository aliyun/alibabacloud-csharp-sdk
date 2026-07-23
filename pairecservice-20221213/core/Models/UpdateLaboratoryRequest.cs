// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateLaboratoryRequest : TeaModel {
        /// <summary>
        /// <para>The number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("BucketCount")]
        [Validation(Required=false)]
        public int? BucketCount { get; set; }

        /// <summary>
        /// <para>The bucketing method. Valid values: ● Uid: Bucketing by UID (default). ● UidHash: Bucketing by UID hash. ● Filter: Bucketing by a filter condition.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The debug crowd ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>The UIDs of debugging users. These UIDs must belong to an Alibaba Cloud main account or a sub-account. Separate multiple UIDs with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1124512470******,1124512471******,1124512472******</para>
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
        /// <para>The environment. Valid values: ● Daily: The daily environment. ● Pre: The staging environment. ● Prod: The production environment.</para>
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
        /// <para>The instance ID. Call the ListInstances operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The laboratory name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>laboratory1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The laboratory type. Valid values: ● Base ● NonBase</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
