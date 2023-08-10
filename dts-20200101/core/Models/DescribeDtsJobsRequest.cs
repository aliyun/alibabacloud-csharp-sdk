// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the DTS dedicated cluster on which the task runs.
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking instance.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the parent task.
        /// 
        /// >  In most cases, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The type of the DTS task. Valid values:
        /// 
        /// *   **MIGRATION**: data migration. This is the default value.
        /// *   **SYNC**: data synchronization.
        /// *   **SUBSCRIBE**: change tracking.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// The basis on which the returned DTS tasks are sorted. Valid values:
        /// 
        /// *   **CreateTime**: sorts the DTS tasks based on the points in time when the DTS tasks are created.
        /// *   **FinishTime**: sorts the DTS tasks based on the points in time when the DTS tasks are complete.
        /// *   **duLimit** sorts the DTS tasks based on the upper limits on DTS Units (DUs) that the DTS tasks can use. This option applies only to the DTS tasks that are run on a DTS dedicated cluster.
        /// 
        /// >  You can also set the **OrderDirection** parameter to specify whether to sort the DTS tasks in ascending or descending order.
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// The order in which the returned DTS tasks are sorted. Valid values:
        /// 
        /// *   **ASC**: sorts the DTS tasks in ascending order. This is the default value.
        /// *   **DESC**: sorts the DTS tasks in descending order.
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than **0** and does not exceed the maximum value of the Integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The content of the query condition.
        /// 
        /// >  You must set the **Type** parameter to specify the type of the query condition.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// The ID of the region in which the DTS instance resides. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// This parameter is discontinued.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The state of the DTS task.
        /// 
        /// Valid values for a data migration task:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is being prechecked.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **PreCheckPass**: The task passed the precheck.
        /// *   **NotConfigured**: The task is not configured.
        /// *   **Migrating**: The task is in progress.
        /// *   **Suspending**: The task is paused.
        /// *   **MigrationFailed**: The task failed.
        /// *   **Finished**: The task is complete.
        /// *   **Retrying**: The task is being retried.
        /// *   **Upgrade**: The task is being upgraded.
        /// *   **Locked**: The task is locked.
        /// *   **Downgrade**: The task is being downgraded.
        /// 
        /// Valid values for a data synchronization task:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is being prechecked.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **PreCheckPass**: The task passed the precheck.
        /// *   **NotConfigured**: The task is not configured.
        /// *   **Initializing**: The task is being initialized.
        /// *   **InitializeFailed**: Initialization failed.
        /// *   **Synchronizing**: The task is in progress.
        /// *   **Failed**: The task failed.
        /// *   **Suspending**: The task is paused.
        /// *   **Modifying**: The objects in the task are being modified.
        /// *   **Finished**: The task is complete.
        /// *   **Retrying**: The task is being retried.
        /// *   **Upgrade**: The task is being upgraded.
        /// *   **Locked**: The task is locked.
        /// *   **Downgrade**: The task is being downgraded.
        /// 
        /// Valid values for a change tracking task:
        /// 
        /// *   **NotConfigured**: The task is not configured.
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is being prechecked.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **PreCheckPass**: The task passed the precheck.
        /// *   **Starting**: The task is being started.
        /// *   **Normal**: The task is running as expected.
        /// *   **Retrying**: The task is being retried.
        /// *   **Abnormal**: The task is not running as expected.
        /// *   **Upgrade**: The task is being upgraded.
        /// *   **Locked**: The task is locked.
        /// *   **Downgrade**: The task is being downgraded.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags of the DTS task to be queried. Specify tags in the JSON format.
        /// 
        /// >  You can call the **ListTagResources** operation to query the tag key and tag value.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The type of the query condition. Valid values:
        /// 
        /// *   **instance**: queries DTS tasks based on the ID of a DTS instance.
        /// *   **name**: queries DTS tasks based on the name of a DTS instance. Fuzzy match is supported.
        /// *   **srcRds**: queries DTS tasks based on the ID of an ApsaraDB RDS instance. The ApsaraDB RDS instance is the source instance of a DTS task.
        /// *   **rds**: queries DTS tasks based on the ID of an ApsaraDB RDS instance. The ApsaraDB RDS instance is the destination instance of a DTS task.
        /// 
        /// >  You must set the **Params** parameter to specify the content of the query condition.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies whether to skip the **DbObject** parameter in the response. The DbObject parameter specifies the objects of the data migration, data synchronization, or change tracking task. Valid values:
        /// 
        /// - **true**: does not return **DbObject**.
        /// - **false**: returns **DbObject**. If you set this parameter to false, the response time is shortened.
        /// </summary>
        [NameInMap("WithoutDbList")]
        [Validation(Required=false)]
        public bool? WithoutDbList { get; set; }

    }

}
