// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateAdamBenchTaskRequest : TeaModel {
        /// <summary>
        /// The description of the stress testing task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the destination instance. The instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance. You can call the [GetInstanceInspections](https://help.aliyun.com/document_detail/202857.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DstInstanceId")]
        [Validation(Required=false)]
        public string DstInstanceId { get; set; }

        /// <summary>
        /// The name of the privileged account for the destination instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DstSuperAccount")]
        [Validation(Required=false)]
        public string DstSuperAccount { get; set; }

        /// <summary>
        /// The password of the privileged account for the destination instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DstSuperPassword")]
        [Validation(Required=false)]
        public string DstSuperPassword { get; set; }

        /// <summary>
        /// The rate at which the traffic captured from the source database instance is replayed on the destination database instance. Valid values: 1 to 30. Default value: 1.
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public int? Rate { get; set; }

        /// <summary>
        /// The duration of the stress testing task for which the traffic is captured from the source instance. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestDuration")]
        [Validation(Required=false)]
        public long? RequestDuration { get; set; }

        /// <summary>
        /// The start time of the stress testing task. Specify the time in the UNIX timestamp format. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestStartTime")]
        [Validation(Required=false)]
        public long? RequestStartTime { get; set; }

        /// <summary>
        /// The database engine that the source database instance runs.
        /// </summary>
        [NameInMap("SrcEngine")]
        [Validation(Required=false)]
        public string SrcEngine { get; set; }

        /// <summary>
        /// The version of the database engine that the source database instance runs.
        /// </summary>
        [NameInMap("SrcEngineVersion")]
        [Validation(Required=false)]
        public string SrcEngineVersion { get; set; }

        /// <summary>
        /// The maximum number of queries per second (QPS) within the time period during which traffic on the source database instance is captured. The value must be accurate to two decimal places.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SrcMaxQps")]
        [Validation(Required=false)]
        public double? SrcMaxQps { get; set; }

        /// <summary>
        /// The average QPS within the time period in which traffic on the source database instance is captured. The value must be accurate to two decimal places.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SrcMeanQps")]
        [Validation(Required=false)]
        public double? SrcMeanQps { get; set; }

        /// <summary>
        /// The URL of the Object Storage Service (OSS) folder in which the archived objects for SQL statements that run on the source database instance are stored. You can obtain the URL after you upload the archived files to OSS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SrcSqlOssAddr")]
        [Validation(Required=false)]
        public string SrcSqlOssAddr { get; set; }

    }

}
