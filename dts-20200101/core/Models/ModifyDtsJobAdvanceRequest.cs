// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobAdvanceRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The **ClientToken** parameter can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform full data migration or synchronization. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// Specifies whether to perform incremental data migration or synchronization. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        /// <summary>
        /// The objects of the data synchronization task after modification. The value must be a JSON string. For more information, see [Objects of DTS tasks](https://help.aliyun.com/document_detail/209545.html).
        /// 
        /// > 
        /// 
        /// *   The new value of DbList overwrites the original value. Make sure that all the objects that you want to synchronize are specified. Otherwise, some objects may be lost. Specify this parameter with caution.
        /// 
        /// *   Before you call the ModifyDtsJob operation, we recommend that you call the [DescribeDtsJobDetail](https://help.aliyun.com/document_detail/208925.html) operation to query the current objects of the data synchronization task. Then, you can specify the new objects based on your business requirements. For example, if the current objects are Table A and Table B and you need to add Table C, you must specify Table A, Table B, and Table C for this parameter.
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public Dictionary<string, object> DbList { get; set; }

        /// <summary>
        /// The ID of the data synchronization instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The synchronization task ID. You can call the [DescribeDtsJobs](https://help.aliyun.com/document_detail/209702.html) operation to query the task ID.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The operator that is related to the extract, transform, and load (ETL) feature and dedicated to T+1 business.
        /// </summary>
        [NameInMap("EtlOperatorColumnReference")]
        [Validation(Required=false)]
        public string EtlOperatorColumnReference { get; set; }

        /// <summary>
        /// The endpoint of the Object Storage Service (OSS) bucket in which the files to be synchronized are stored.
        /// </summary>
        [NameInMap("FileOssUrl")]
        [Validation(Required=false)]
        public Stream FileOssUrlObject { get; set; }

        /// <summary>
        /// The name of the table to be filtered.
        /// </summary>
        [NameInMap("FilterTableName")]
        [Validation(Required=false)]
        public string FilterTableName { get; set; }

        /// <summary>
        /// The method that is used to modify the data synchronization task. If you do not specify the parameter, the objects of the data synchronization task are modified by default. If you specify UPDATE_RESERVED for the parameter, the reserved parameters are modified.
        /// </summary>
        [NameInMap("ModifyTypeEnum")]
        [Validation(Required=false)]
        public string ModifyTypeEnum { get; set; }

        /// <summary>
        /// The ID of the region in which the data synchronization instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The reserved parameters of the data synchronization task. You can add reserved parameters instead of overwriting the existing reserved parameters. The value of the parameter is a MAP JSON string. You can specify this parameter to meet special requirements, such as specifying whether to automatically start the precheck of the data synchronization task. For more information, see [MigrationReserved](https://help.aliyun.com/document_detail/176470.html).
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to perform schema migration or synchronization. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**: Data is synchronized from the source database to the destination database.
        /// *   **Reverse**: Data is synchronized from the destination database to the source database.
        /// 
        /// > 
        /// *   Default value: **Forward**.
        /// *   This parameter is required only if the topology of the data synchronization instance is two-way synchronization.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
