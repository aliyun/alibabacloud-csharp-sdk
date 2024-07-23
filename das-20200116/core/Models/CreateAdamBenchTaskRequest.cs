// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateAdamBenchTaskRequest : TeaModel {
        /// <summary>
        /// <para>The description of the stress testing task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-das-bench-0501</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the destination instance. The instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance. You can call the <a href="https://help.aliyun.com/document_detail/202857.html">GetInstanceInspections</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("DstInstanceId")]
        [Validation(Required=false)]
        public string DstInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the privileged account for the destination instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root***</para>
        /// </summary>
        [NameInMap("DstSuperAccount")]
        [Validation(Required=false)]
        public string DstSuperAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account for the destination instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root***1234</para>
        /// </summary>
        [NameInMap("DstSuperPassword")]
        [Validation(Required=false)]
        public string DstSuperPassword { get; set; }

        /// <summary>
        /// <para>The rate at which the traffic captured from the source database instance is replayed on the destination database instance. Valid values: 1 to 30. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public int? Rate { get; set; }

        /// <summary>
        /// <para>The duration of the stress testing task for which the traffic is captured from the source instance. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("RequestDuration")]
        [Validation(Required=false)]
        public long? RequestDuration { get; set; }

        /// <summary>
        /// <para>The start time of the stress testing task. Specify the time in the UNIX timestamp format. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1588819800000</para>
        /// </summary>
        [NameInMap("RequestStartTime")]
        [Validation(Required=false)]
        public long? RequestStartTime { get; set; }

        /// <summary>
        /// <para>The database engine that the source database instance runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SrcEngine")]
        [Validation(Required=false)]
        public string SrcEngine { get; set; }

        /// <summary>
        /// <para>The version of the database engine that the source database instance runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9i</para>
        /// </summary>
        [NameInMap("SrcEngineVersion")]
        [Validation(Required=false)]
        public string SrcEngineVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of queries per second (QPS) within the time period during which traffic on the source database instance is captured. The value must be accurate to two decimal places.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2013.22</para>
        /// </summary>
        [NameInMap("SrcMaxQps")]
        [Validation(Required=false)]
        public double? SrcMaxQps { get; set; }

        /// <summary>
        /// <para>The average QPS within the time period in which traffic on the source database instance is captured. The value must be accurate to two decimal places.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>312.22</para>
        /// </summary>
        [NameInMap("SrcMeanQps")]
        [Validation(Required=false)]
        public double? SrcMeanQps { get; set; }

        /// <summary>
        /// <para>The URL of the Object Storage Service (OSS) folder in which the archived objects for SQL statements that run on the source database instance are stored. You can obtain the URL after you upload the archived files to OSS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://rdslog-hz-v3.oss-cn-hangzhou.aliyuncs.com/custins4131">http://rdslog-hz-v3.oss-cn-hangzhou.aliyuncs.com/custins4131</a>****</para>
        /// </summary>
        [NameInMap("SrcSqlOssAddr")]
        [Validation(Required=false)]
        public string SrcSqlOssAddr { get; set; }

    }

}
