// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateImportMigrationAdvanceRequest : TeaModel {
        /// <summary>
        /// The mapping between the source compute engine instance and the destination compute engine instance.
        /// 
        /// The following types of compute engine instances are supported: MaxCompute, E-MapReduce (EMR), Hadoop CDH, and Hologres.
        /// </summary>
        [NameInMap("CalculateEngineMap")]
        [Validation(Required=false)]
        public string CalculateEngineMap { get; set; }

        /// <summary>
        /// The rule configured for automatically committing and deploying the import task. The rule contains the following parameters:
        /// 
        /// *   resourceAutoCommit: specifies whether resources are automatically committed. The value true indicates that the resources are automatically committed, and the value false indicates that the resources are not automatically committed.
        /// *   resourceAutoDeploy: specifies whether resources are automatically deployed. The value true indicates that the resources are automatically deployed, and the value false indicates that the resources are not automatically deployed.
        /// *   functionAutoCommit: specifies whether the function is automatically committed. The value true indicates that the function is automatically committed, and the value false indicates that the function is not automatically committed.
        /// *   functionAutoDeploy: specifies whether the function is automatically deployed. The value true indicates that the function is automatically deployed, and the value false indicates that the function is not automatically deployed.
        /// *   tableAutoCommitToDev: specifies whether the table is automatically committed to the development environment. The value true indicates that the table is automatically committed to the development environment, and the value false indicates that the table is not automatically committed to the development environment.
        /// *   tableAutoCommitToProd: specifies whether the table is automatically committed to the production environment. The value true indicates that the table is automatically committed to the production environment, and the value false indicates that the table is not automatically committed to the production environment.
        /// *   ignoreLock: specifies whether the lock is automatically ignored when an import task is locked. The value true indicates that the lock is automatically ignored, and the value false indicates that the lock is not automatically ignored. If you set this parameter to true for an import task, you can forcibly update the task even if the task is locked.
        /// *   fileAutoCommit: specifies whether the file is automatically committed. The value true indicates that the file is automatically committed, and the value false indicates that the file is not automatically committed.
        /// *   fileAutoDeploy: specifies whether the file is automatically deployed. The value true indicates that the file is automatically deployed, and the value false indicates that the file is not automatically deployed.
        /// </summary>
        [NameInMap("CommitRule")]
        [Validation(Required=false)]
        public string CommitRule { get; set; }

        /// <summary>
        /// The description of the import package.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the import task. The name must be unique within the workspace.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The path of the import package.
        /// 
        /// **The import package must be uploaded. Example of the upload method:**`  Config config = new Config(); config.setAccessKeyId(accessId); config.setAccessKeySecret(accessKey); config.setEndpoint(popEndpoint); config.setRegionId(regionId); Client client = new Client(config); CreateImportMigrationAdvanceRequest request = new CreateImportMigrationAdvanceRequest(); request.setName("test_migration_api_" + System.currentTimeMillis()); request.setProjectId(123456L); request.setPackageType("DATAWORKS_MODEL"); request.setPackageFileObject(new FileInputStream("/home/admin/Downloads/test.zip")); RuntimeOptions runtime = new RuntimeOptions(); CreateImportMigrationResponse response = client.createImportMigrationAdvance(request, runtime); ... `
        /// </summary>
        [NameInMap("PackageFile")]
        [Validation(Required=false)]
        public Stream PackageFileObject { get; set; }

        /// <summary>
        /// The type of the import package. Valid values:
        /// 
        /// *   DATAWORKS_MODEL (standard format)
        /// *   DATAWORKS_V2 (Apsara Stack DataWorks V3.6.1 to V3.11)
        /// *   DATAWORKS_V3 (Apsara Stack DataWorks V3.12 and later)
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Management page to obtain the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The mapping between the resource group for scheduling and the resource group for Data Integration. The keys and values in the mapping are the identifiers of the resource groups. Specify the mapping in the following format:
        /// 
        /// ```
        /// 
        /// {
        ///     "SCHEDULER_RESOURCE_GROUP": {
        ///         "xxx": "yyy"
        ///     },
        ///     "DI_RESOURCE_GROUP": {
        ///         "ccc": "dfdd"
        ///     }
        /// }
        /// 
        ///                                 
        /// ```
        /// </summary>
        [NameInMap("ResourceGroupMap")]
        [Validation(Required=false)]
        public string ResourceGroupMap { get; set; }

        /// <summary>
        /// The mapping between the prefixes for the names of the source and destination workspaces. When the system performs the import operation, the prefix for the name of the source workspace in the import package is replaced based on the mapping.
        /// </summary>
        [NameInMap("WorkspaceMap")]
        [Validation(Required=false)]
        public string WorkspaceMap { get; set; }

    }

}
