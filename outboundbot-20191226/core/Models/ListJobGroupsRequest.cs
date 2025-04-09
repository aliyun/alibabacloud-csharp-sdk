// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncQuery")]
        [Validation(Required=false)]
        public bool? AsyncQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1579965079000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupStatusFilter")]
        [Validation(Required=false)]
        public string JobGroupStatusFilter { get; set; }

        [NameInMap("OnlyMinConcurrencyEnabled")]
        [Validation(Required=false)]
        public bool? OnlyMinConcurrencyEnabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1578965079000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
