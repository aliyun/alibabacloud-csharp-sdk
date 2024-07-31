// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIJobShrinkRequest : TeaModel {
        /// <summary>
        /// The description of the synchronization task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The settings of the destination. Only a single destination is supported.
        /// </summary>
        [NameInMap("DestinationDataSourceSettings")]
        [Validation(Required=false)]
        public string DestinationDataSourceSettingsShrink { get; set; }

        /// <summary>
        /// The type of the destination. Valid values: Hologres and Hive.
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        /// <summary>
        /// The name of the synchronization task.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public string JobSettingsShrink { get; set; }

        /// <summary>
        /// The synchronization type. Valid values:
        /// 
        /// *   FullAndRealtimeIncremental (one-time full synchronization and real-time incremental synchronization)
        /// *   RealtimeIncremental (real-time incremental synchronization)
        /// *   Full (full synchronization)
        /// *   OfflineIncremental (batch incremental synchronization)
        /// *   FullAndOfflineIncremental (one-time full synchronization and batch incremental synchronization)
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to obtain the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The resource settings.
        /// </summary>
        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public string ResourceSettingsShrink { get; set; }

        /// <summary>
        /// The settings of the source. Only a single source is supported.
        /// </summary>
        [NameInMap("SourceDataSourceSettings")]
        [Validation(Required=false)]
        public string SourceDataSourceSettingsShrink { get; set; }

        /// <summary>
        /// The type of the source. Set the value to MySQL.
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// Specifies whether to perform system debugging. Valid values: true and false. Default value: false.
        /// </summary>
        [NameInMap("SystemDebug")]
        [Validation(Required=false)]
        public string SystemDebug { get; set; }

        /// <summary>
        /// The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public string TableMappingsShrink { get; set; }

        /// <summary>
        /// The list of transformation rules for objects involved in the synchronization task. Each entry in the list defines a transformation rule.
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public string TransformationRulesShrink { get; set; }

    }

}
