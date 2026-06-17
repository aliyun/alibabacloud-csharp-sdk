// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeLogStoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information list.</para>
        /// </summary>
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public List<DescribeLogStoreInfoResponseBodyInfoList> InfoList { get; set; }
        public class DescribeLogStoreInfoResponseBodyInfoList : TeaModel {
            /// <summary>
            /// <para>The name of the SLS Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx-logstore</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The maximum number of shards supported for scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxSplitShard")]
            [Validation(Required=false)]
            public int? MaxSplitShard { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudfirewall-project-14151892848****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The storage capacity threshold, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000000</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of shards in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public int? Shard { get; set; }

            /// <summary>
            /// <para>The location of the Logstore. Valid values: \<c>cn\\</c> for the Chinese mainland and \<c>intl\\</c> for regions outside the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>The storage duration of logs, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The amount of stored logs, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21852955752</para>
            /// </summary>
            [NameInMap("Used")]
            [Validation(Required=false)]
            public long? Used { get; set; }

        }

        /// <summary>
        /// <para>The number of times the log storage mode can be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LogModifyQuota")]
        [Validation(Required=false)]
        public int? LogModifyQuota { get; set; }

        /// <summary>
        /// <para>The name of the SLS Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The log version. 1: indicates one Logstore. 2: indicates two Logstores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LogVersion")]
        [Validation(Required=false)]
        public int? LogVersion { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-xxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The available log storage capacity, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000000</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <para>The ID of the region where logs are delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6C3B72B********E95FB0A161</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The total purchased log storage capacity, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000000</para>
        /// </summary>
        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        /// <summary>
        /// <para>The storage duration of logs, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The used storage capacity, in bytes.</para>
        /// <remarks>
        /// <para>Statistics from Simple Log Service may be delayed by up to two hours.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

    }

}
