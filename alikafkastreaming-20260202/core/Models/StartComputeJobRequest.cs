// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class StartComputeJobRequest : TeaModel {
        /// <summary>
        /// <para>The CU limit for the job. Integers and decimals are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("CuLimit")]
        [Validation(Required=false)]
        public double? CuLimit { get; set; }

        /// <summary>
        /// <para>The number of reserved CUs for the job. Integers and decimals are supported.</para>
        /// <remarks>
        /// <para>The number of reserved CUs cannot exceed the CU limit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("CuReserved")]
        [Validation(Required=false)]
        public double? CuReserved { get; set; }

        /// <summary>
        /// <para><b>The Flink SQL draft, which must be a self-contained and complete DDL and DML statement.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE TEMPORARY TABLE src (id BIGINT) WITH (\&quot;connector\&quot; = \&quot;datagen\&quot;); CREATE TEMPORARY TABLE sink (id BIGINT) WITH (\&quot;connector\&quot; = \&quot;print\&quot;); INSERT INTO sink SELECT id FROM src;</para>
        /// </summary>
        [NameInMap("DraftSql")]
        [Validation(Required=false)]
        public string DraftSql { get; set; }

        /// <summary>
        /// <para><b>The compute instance ID.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_streaming-cn-pe333xxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para><b>The name of the compute job.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_enrichment</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para><b>The recovery mode, such as savepoint or stateless.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>savepoint</para>
        /// </summary>
        [NameInMap("RecoveryMode")]
        [Validation(Required=false)]
        public string RecoveryMode { get; set; }

        /// <summary>
        /// <para><b>The region ID.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
