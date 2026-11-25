// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateFeatureConsistencyCheckJobConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to compare features.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompareFeature")]
        [Validation(Required=false)]
        public bool? CompareFeature { get; set; }

        /// <summary>
        /// <para>The ID of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-xxx</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The mount path of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mnt/xxx</para>
        /// </summary>
        [NameInMap("DatasetMountPath")]
        [Validation(Required=false)]
        public string DatasetMountPath { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The type of the OSS dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>The URI of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-xxx</para>
        /// </summary>
        [NameInMap("DatasetUri")]
        [Validation(Required=false)]
        public string DatasetUri { get; set; }

        /// <summary>
        /// <para>The default gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Eth0: public gateway.</description></item>
        /// <item><description>Eth1: dedicated gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Eth0</para>
        /// </summary>
        [NameInMap("DefaultRoute")]
        [Validation(Required=false)]
        public string DefaultRoute { get; set; }

        /// <summary>
        /// <para>The name of the PAI-EAS service. For more information about how to obtain the service name, see <a href="https://help.aliyun.com/document_detail/412109.html">ListServices</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service_123</para>
        /// </summary>
        [NameInMap("EasServiceName")]
        [Validation(Required=false)]
        public string EasServiceName { get; set; }

        /// <summary>
        /// <para>The OSS bucket path of the EasyRec package.</para>
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
        /// <para>The feature display filter. Separate multiple features with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature1,feature2</para>
        /// </summary>
        [NameInMap("FeatureDisplayExclude")]
        [Validation(Required=false)]
        public string FeatureDisplayExclude { get; set; }

        /// <summary>
        /// <para>The ID of the data backflow data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-********</para>
        /// </summary>
        [NameInMap("FeatureLandingResourceId")]
        [Validation(Required=false)]
        public string FeatureLandingResourceId { get; set; }

        /// <summary>
        /// <para>The feature priority. Separate multiple features with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature1,feature2,feature3</para>
        /// </summary>
        [NameInMap("FeaturePriority")]
        [Validation(Required=false)]
        public string FeaturePriority { get; set; }

        /// <summary>
        /// <para>The primary key on the item side in Feature Store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("FeatureStoreItemId")]
        [Validation(Required=false)]
        public string FeatureStoreItemId { get; set; }

        /// <summary>
        /// <para>The feature store model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureStoreModelId")]
        [Validation(Required=false)]
        public string FeatureStoreModelId { get; set; }

        /// <summary>
        /// <para>The ID of the Feature Store project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prj-01</para>
        /// </summary>
        [NameInMap("FeatureStoreProjectId")]
        [Validation(Required=false)]
        public string FeatureStoreProjectId { get; set; }

        /// <summary>
        /// <para>The name of the Feature Store project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-1</para>
        /// </summary>
        [NameInMap("FeatureStoreProjectName")]
        [Validation(Required=false)]
        public string FeatureStoreProjectName { get; set; }

        /// <summary>
        /// <para>The name of the feature view to which the item features in the sequence features belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item-1</para>
        /// </summary>
        [NameInMap("FeatureStoreSeqFeatureView")]
        [Validation(Required=false)]
        public string FeatureStoreSeqFeatureView { get; set; }

        /// <summary>
        /// <para>The primary key on the user side in Feature Store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("FeatureStoreUserId")]
        [Validation(Required=false)]
        public string FeatureStoreUserId { get; set; }

        /// <summary>
        /// <para>The fg_jar version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("FgJarVersion")]
        [Validation(Required=false)]
        public string FgJarVersion { get; set; }

        /// <summary>
        /// <para>The name of the fg_json file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.json</para>
        /// </summary>
        [NameInMap("FgJsonFileName")]
        [Validation(Required=false)]
        public string FgJsonFileName { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a ZIP package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GenerateZip")]
        [Validation(Required=false)]
        public bool? GenerateZip { get; set; }

        /// <summary>
        /// <para>The ID of the instance. For more information about how to obtain the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the item_id field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item_id</para>
        /// </summary>
        [NameInMap("ItemIdField")]
        [Validation(Required=false)]
        public string ItemIdField { get; set; }

        /// <summary>
        /// <para>The name of the item table.</para>
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
        /// <para>The format of the partition field for the item table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>yyyymmdd</description></item>
        /// <item><description>yyyy-mm-dd</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yyyymmdd</para>
        /// </summary>
        [NameInMap("ItemTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string ItemTablePartitionFieldFormat { get; set; }

        /// <summary>
        /// <para>maxcompute schema</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("MaxcomputeSchema")]
        [Validation(Required=false)]
        public string MaxcomputeSchema { get; set; }

        /// <summary>
        /// <para>The name of the feature consistency check.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature_consistency_check1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the OSS data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-********</para>
        /// </summary>
        [NameInMap("OssResourceId")]
        [Validation(Required=false)]
        public string OssResourceId { get; set; }

        /// <summary>
        /// <para>The number of workers used to execute the prediction script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PredictWorkerCount")]
        [Validation(Required=false)]
        public int? PredictWorkerCount { get; set; }

        /// <summary>
        /// <para>The CPU allocated to the worker for executing the prediction script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PredictWorkerCpu")]
        [Validation(Required=false)]
        public int? PredictWorkerCpu { get; set; }

        /// <summary>
        /// <para>The memory allocated to the worker for executing the prediction script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32000</para>
        /// </summary>
        [NameInMap("PredictWorkerMemory")]
        [Validation(Required=false)]
        public int? PredictWorkerMemory { get; set; }

        /// <summary>
        /// <para>The resource configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public string ResourceConfig { get; set; }

        /// <summary>
        /// <para>The sampling ratio (0-1).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.89</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public double? SampleRate { get; set; }

        /// <summary>
        /// <para>The ID of the scene.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thax-xxx</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vswitch-xxx</para>
        /// </summary>
        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use Feature Store. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: uses Feature Store. In this case, FeatureStoreProjectId, FeatureStoreProjectName, FeatureStoreModelId, FeatureStoreUserId, and FeatureStoreItemId are required.</description></item>
        /// <item><description>false: does not use Feature Store. In this case, UserTable, UserIdField, UserTablePartitionField, UserTablePartitionFieldFormat, ItemTable, ItemIdField, ItemTablePartitionField, and ItemTablePartitionFieldFormat are required.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFeatureStore")]
        [Validation(Required=false)]
        public bool? UseFeatureStore { get; set; }

        /// <summary>
        /// <para>The name of the user_id field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_id</para>
        /// </summary>
        [NameInMap("UserIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

        /// <summary>
        /// <para>The name of the user table.</para>
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
        /// <para>The format of the partition field for the user table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>yyyymmdd</description></item>
        /// <item><description>yyyy-mm-dd</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yyyymmdd</para>
        /// </summary>
        [NameInMap("UserTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string UserTablePartitionFieldFormat { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work_flow_1</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// <para>The ID of the PAI workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
