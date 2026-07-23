// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetFeatureConsistencyCheckJobConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Whether to enable feature comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompareFeature")]
        [Validation(Required=false)]
        public bool? CompareFeature { get; set; }

        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        [NameInMap("DatasetMountPath")]
        [Validation(Required=false)]
        public string DatasetMountPath { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        [NameInMap("DatasetUri")]
        [Validation(Required=false)]
        public string DatasetUri { get; set; }

        [NameInMap("DefaultRoute")]
        [Validation(Required=false)]
        public string DefaultRoute { get; set; }

        /// <summary>
        /// <para>The EAS service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas_service_1</para>
        /// </summary>
        [NameInMap("EasServiceName")]
        [Validation(Required=false)]
        public string EasServiceName { get; set; }

        /// <summary>
        /// <para>The path of the EasyRec package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://*******</para>
        /// </summary>
        [NameInMap("EasyRecPackagePath")]
        [Validation(Required=false)]
        public string EasyRecPackagePath { get; set; }

        /// <summary>
        /// <para>The EasyRec version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.3.60</para>
        /// </summary>
        [NameInMap("EasyRecVersion")]
        [Validation(Required=false)]
        public string EasyRecVersion { get; set; }

        /// <summary>
        /// <para>A comma-separated list of features to exclude from the display.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature1,feature2</para>
        /// </summary>
        [NameInMap("FeatureDisplayExclude")]
        [Validation(Required=false)]
        public string FeatureDisplayExclude { get; set; }

        /// <summary>
        /// <para>The ID of the data source for feature fallback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-********</para>
        /// </summary>
        [NameInMap("FeatureLandingResourceId")]
        [Validation(Required=false)]
        public string FeatureLandingResourceId { get; set; }

        /// <summary>
        /// <para>The URI of the data source for feature fallback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc_project_1</para>
        /// </summary>
        [NameInMap("FeatureLandingResourceUri")]
        [Validation(Required=false)]
        public string FeatureLandingResourceUri { get; set; }

        /// <summary>
        /// <para>A comma-separated list of features, ordered by priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature1,feature2,feature3</para>
        /// </summary>
        [NameInMap("FeaturePriority")]
        [Validation(Required=false)]
        public string FeaturePriority { get; set; }

        /// <summary>
        /// <para>The primary key for items in the Feature Store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("FeatureStoreItemId")]
        [Validation(Required=false)]
        public string FeatureStoreItemId { get; set; }

        /// <summary>
        /// <para>The Feature Store model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureStoreModelId")]
        [Validation(Required=false)]
        public string FeatureStoreModelId { get; set; }

        /// <summary>
        /// <para>The Feature Store project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prj-01</para>
        /// </summary>
        [NameInMap("FeatureStoreProjectId")]
        [Validation(Required=false)]
        public string FeatureStoreProjectId { get; set; }

        /// <summary>
        /// <para>The Feature Store project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-1</para>
        /// </summary>
        [NameInMap("FeatureStoreProjectName")]
        [Validation(Required=false)]
        public string FeatureStoreProjectName { get; set; }

        /// <summary>
        /// <para>The name of the feature view that contains item features within sequence features.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item-1</para>
        /// </summary>
        [NameInMap("FeatureStoreSeqFeatureView")]
        [Validation(Required=false)]
        public string FeatureStoreSeqFeatureView { get; set; }

        /// <summary>
        /// <para>The primary key for users in the Feature Store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("FeatureStoreUserId")]
        [Validation(Required=false)]
        public string FeatureStoreUserId { get; set; }

        /// <summary>
        /// <para>The version of the <c>fg_jar</c> file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("FgJarVersion")]
        [Validation(Required=false)]
        public string FgJarVersion { get; set; }

        /// <summary>
        /// <para>The name of the <c>fg_json</c> file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.json</para>
        /// </summary>
        [NameInMap("FgJsonFileName")]
        [Validation(Required=false)]
        public string FgJsonFileName { get; set; }

        /// <summary>
        /// <para>Whether to generate a ZIP package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GenerateZip")]
        [Validation(Required=false)]
        public bool? GenerateZip { get; set; }

        /// <summary>
        /// <para>The time the configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time the configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the <c>item_id</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item_id</para>
        /// </summary>
        [NameInMap("ItemIdField")]
        [Validation(Required=false)]
        public string ItemIdField { get; set; }

        /// <summary>
        /// <para>The item table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item_table</para>
        /// </summary>
        [NameInMap("ItemTable")]
        [Validation(Required=false)]
        public string ItemTable { get; set; }

        /// <summary>
        /// <para>The partition field of the item table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds</para>
        /// </summary>
        [NameInMap("ItemTablePartitionField")]
        [Validation(Required=false)]
        public string ItemTablePartitionField { get; set; }

        /// <summary>
        /// <para>The format of the partition field in the item table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>yyyymmdd</c></para>
        /// </description></item>
        /// <item><description><para><c>yyyy-mm-dd</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yyyymmdd</para>
        /// </summary>
        [NameInMap("ItemTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string ItemTablePartitionFieldFormat { get; set; }

        /// <summary>
        /// <para>The end time of the most recent job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("LatestJobGmtSamplingEndTime")]
        [Validation(Required=false)]
        public string LatestJobGmtSamplingEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the most recent job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("LatestJobGmtSamplingStartTime")]
        [Validation(Required=false)]
        public string LatestJobGmtSamplingStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the most recent job created from this configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LatestJobId")]
        [Validation(Required=false)]
        public string LatestJobId { get; set; }

        /// <summary>
        /// <para>The name of the feature consistency check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature_consistency_check1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OSS bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss_bucket_1</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The ID of the OSS data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-********</para>
        /// </summary>
        [NameInMap("OssResourceId")]
        [Validation(Required=false)]
        public string OssResourceId { get; set; }

        [NameInMap("PredictWorkerCount")]
        [Validation(Required=false)]
        public int? PredictWorkerCount { get; set; }

        [NameInMap("PredictWorkerCpu")]
        [Validation(Required=false)]
        public int? PredictWorkerCpu { get; set; }

        [NameInMap("PredictWorkerMemory")]
        [Validation(Required=false)]
        public int? PredictWorkerMemory { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public string ResourceConfig { get; set; }

        /// <summary>
        /// <para>The sample rate. The value must be between 0 and 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.89</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

        /// <summary>
        /// <para>The scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The scene name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scene1</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service1</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The status of the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Editable</c>: The configuration can be edited.</para>
        /// </description></item>
        /// <item><description><para><c>Uneditable</c>: The configuration cannot be edited.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Editable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

        /// <summary>
        /// <para>Whether to use a Feature Store. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: A Feature Store is used. In this case, the response also returns <c>FeatureStoreProjectId</c>, <c>FeatureStoreProjectName</c>, <c>FeatureStoreModelId</c>, <c>FeatureStoreUserId</c>, and <c>FeatureStoreItemId</c>.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: A Feature Store is not used. In this case, the <c>UserTable</c>, <c>UserIdField</c>, <c>UserTablePartitionField</c>, <c>UserTablePartitionFieldFormat</c>, <c>ItemTable</c>, <c>ItemIdField</c>, <c>ItemTablePartitionField</c>, and <c>ItemTablePartitionFieldFormat</c> parameters are returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFeatureStore")]
        [Validation(Required=false)]
        public bool? UseFeatureStore { get; set; }

        /// <summary>
        /// <para>The name of the <c>user_id</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_id</para>
        /// </summary>
        [NameInMap("UserIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

        /// <summary>
        /// <para>The user table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_table</para>
        /// </summary>
        [NameInMap("UserTable")]
        [Validation(Required=false)]
        public string UserTable { get; set; }

        /// <summary>
        /// <para>The partition field of the user table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds</para>
        /// </summary>
        [NameInMap("UserTablePartitionField")]
        [Validation(Required=false)]
        public string UserTablePartitionField { get; set; }

        /// <summary>
        /// <para>The format of the partition field in the user table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>yyyymmdd</c></para>
        /// </description></item>
        /// <item><description><para><c>yyyy-mm-dd</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yyyymmdd</para>
        /// </summary>
        [NameInMap("UserTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string UserTablePartitionFieldFormat { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The workflow name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work_flow_1</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
