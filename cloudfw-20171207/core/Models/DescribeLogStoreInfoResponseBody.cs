// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeLogStoreInfoResponseBody : TeaModel {
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public List<DescribeLogStoreInfoResponseBodyInfoList> InfoList { get; set; }
        public class DescribeLogStoreInfoResponseBodyInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx-logstore</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxSplitShard")]
            [Validation(Required=false)]
            public int? MaxSplitShard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloudfirewall-project-14151892848****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50000000</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public int? Shard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21852955752</para>
            /// </summary>
            [NameInMap("Used")]
            [Validation(Required=false)]
            public long? Used { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LogModifyQuota")]
        [Validation(Required=false)]
        public int? LogModifyQuota { get; set; }

        /// <summary>
        /// <para>The name of the SLS LogStore in the log service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LogVersion")]
        [Validation(Required=false)]
        public int? LogVersion { get; set; }

        /// <summary>
        /// <para>The Project name of the log service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-xxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Available log storage capacity. Unit: Byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000000</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <para>The region ID for log delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6C3B72B********E95FB0A161</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>用户进行日志修改所产生的任务id。</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50000000</para>
        /// </summary>
        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        /// <summary>
        /// <para>Log storage duration. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>Used storage capacity. Unit: Byte.</para>
        /// <remarks>
        /// <para>The statistics of the log service have a delay of approximately two hours.</para>
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
