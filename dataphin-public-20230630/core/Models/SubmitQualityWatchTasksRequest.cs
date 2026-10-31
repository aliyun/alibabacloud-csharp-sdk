// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitQualityWatchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The submit command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitQualityWatchTasksRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitQualityWatchTasksRequestSubmitCommand : TeaModel {
            /// <summary>
            /// <para>The business date. Format: yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>The custom partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=${yyyyMMdd}</para>
            /// </summary>
            [NameInMap("PartitionExpression")]
            [Validation(Required=false)]
            public string PartitionExpression { get; set; }

            /// <summary>
            /// <para>The IDs of the monitored objects.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("WatchIdList")]
            [Validation(Required=false)]
            public List<long?> WatchIdList { get; set; }

        }

    }

}
