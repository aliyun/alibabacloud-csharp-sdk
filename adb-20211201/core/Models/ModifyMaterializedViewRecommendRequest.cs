// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyMaterializedViewRecommendRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6o*****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("MinRewriteQueryCount")]
        [Validation(Required=false)]
        public int? MinRewriteQueryCount { get; set; }

        [NameInMap("MinRewriteQueryPattern")]
        [Validation(Required=false)]
        public int? MinRewriteQueryPattern { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScanQueriesRange")]
        [Validation(Required=false)]
        public int? ScanQueriesRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Monday;Wednesday</para>
        /// </summary>
        [NameInMap("SchedulingDay")]
        [Validation(Required=false)]
        public string SchedulingDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>weekly</para>
        /// </summary>
        [NameInMap("SchedulingPolicy")]
        [Validation(Required=false)]
        public string SchedulingPolicy { get; set; }

        [NameInMap("SlowQueryThreshold")]
        [Validation(Required=false)]
        public int? SlowQueryThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10:00:00</para>
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_n1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
