// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeInitializationStatusResponseBody : TeaModel {
        /// <summary>
        /// The details of initial full data synchronization.
        /// </summary>
        [NameInMap("DataInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataInitializationDetails> DataInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataInitializationDetails : TeaModel {
            /// <summary>
            /// The name of the database to which the object in the destination instance belongs.
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// The error message returned if initial full data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The total number of rows that are actually synchronized.
            /// 
            /// >  This parameter indicates the total number of actually synchronized rows. In contrast, the value of the **TotalRowNum** parameter is calculated based on the system tables in the source database. The values of the two parameters may be different due to time difference.
            /// </summary>
            [NameInMap("FinishRowNum")]
            [Validation(Required=false)]
            public string FinishRowNum { get; set; }

            /// <summary>
            /// The name of the database to which the object in the source instance belongs.
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// The status of initial full data synchronization. Valid values:
            /// 
            /// *   **NotStarted**
            /// *   **Migrating**
            /// *   **Failed**
            /// *   **Finished**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The table name.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The total number of rows that are supposed to be synchronized.
            /// 
            /// >  The value of this parameter is calculated based on the system tables in the source database. In contrast, the **FinishRowNum** parameter indicates the total number of actually synchronized rows. The values of the two parameters may be different due to time difference.
            /// </summary>
            [NameInMap("TotalRowNum")]
            [Validation(Required=false)]
            public string TotalRowNum { get; set; }

            /// <summary>
            /// The time spent on full data synchronization.
            /// </summary>
            [NameInMap("UsedTime")]
            [Validation(Required=false)]
            public string UsedTime { get; set; }

        }

        /// <summary>
        /// The details of incremental data synchronization.
        /// 
        /// >  This parameter and the parameters it contains will be removed in the future.
        /// </summary>
        [NameInMap("DataSynchronizationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataSynchronizationDetails> DataSynchronizationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataSynchronizationDetails : TeaModel {
            /// <summary>
            /// The name of the database to which the object in the destination instance belongs.
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// The error message returned if incremental data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The name of the database to which the object in the source instance belongs.
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// The status of incremental data synchronization. Valid values:
            /// 
            /// *   **NotStarted**
            /// *   **Migrating**
            /// *   **Failed**
            /// *   **Finished**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The table name.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of initial schema synchronization.
        /// </summary>
        [NameInMap("StructureInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyStructureInitializationDetails> StructureInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyStructureInitializationDetails : TeaModel {
            /// <summary>
            /// The constraints of the synchronization object, such as indexes and foreign keys.
            /// 
            /// >  This parameter is returned only if the **ObjectType** parameter is set to **Table** and the synchronization object has constraints.
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public List<DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints> Constraints { get; set; }
            public class DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints : TeaModel {
                /// <summary>
                /// The name of the database to which the object in the destination instance belongs.
                /// </summary>
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                /// <summary>
                /// The error message returned if constraints failed to be created.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The syntax to create constraints.
                /// </summary>
                [NameInMap("ObjectDefinition")]
                [Validation(Required=false)]
                public string ObjectDefinition { get; set; }

                /// <summary>
                /// The name of the object.
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// The type of the object. Valid value: **Table**.
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// The name of the database to which the object in the source instance belongs.
                /// </summary>
                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                /// <summary>
                /// The status of constraint creation. Valid values:
                /// 
                /// *   **NotStarted**
                /// *   **Migrating**
                /// *   **Failed**
                /// *   **Finished**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The name of the database to which the object in the destination instance belongs.
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// The error message returned if initial schema synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The schema of the object.
            /// </summary>
            [NameInMap("ObjectDefinition")]
            [Validation(Required=false)]
            public string ObjectDefinition { get; set; }

            /// <summary>
            /// The name of the object.
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            /// <summary>
            /// The type of the object. Valid values:
            /// 
            /// **Table**, **Constraint**, **Index**, **View**, **Materialize View**, **Type**, **Synonym**, **Trigger**, **Function**, **Procedure**, **Package**, **Default**, **Rule**, **PlanGuide**, and **Sequence**.
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// The name of the database to which the object in the source instance belongs.
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// The status of initial schema synchronization. Valid values:
            /// 
            /// *   **NotStarted**
            /// *   **Migrating**
            /// *   **Failed**
            /// *   **Finished**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
