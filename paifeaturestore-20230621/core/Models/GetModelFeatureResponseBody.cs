// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetModelFeatureResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>from feature_store_py.fs_client import FeatureStoreClient\nfrom feature_store_py.fs_project import FeatureStoreProject\nfrom feature_store_py.fs_datasource import LabelInput, MaxComputeDataSource, TrainingSetOutput\nfrom feature_store_py.fs_features import FeatureSelector\nfrom feature_store_py.fs_config import LabelInputConfig, PartitionConfig, FeatureViewConfig\nfrom feature_store_py.fs_config import TrainSetOutputConfig, EASDeployConfig\nimport datetime\nimport sys\n\ncur_day = args[&quot;dt&quot;]\nprint(&quot;cur_day = &quot;, cur_day)\noffset = datetime.timedelta(days=-1)\npre_day = (datetime.datetime.strptime(cur_day, &quot;%Y%m%d&quot;) + offset).strftime(&quot;%Y%m%d&quot;)\nprint(&quot;pre_day = &quot;, pre_day)\n\n\naccess_key_id = o.account.access_id\naccess_key_secret = o.account.secret_access_key\nfs = FeatureStoreClient(access_key_id=access_key_id, access_key_secret=access_key_secret, region=&quot;cn-beijing&quot;)\ncur_project_name = &quot;p1&quot;\nproject = fs.get_project(cur_project_name)\n\nlabel_partitions = PartitionConfig(name = &quot;ds&quot;, value = cur_day)\nlabel_input_config = LabelInputConfig(partition_config=label_partitions)\n\nfeature_view_1_partitions = PartitionConfig(name = &quot;ds&quot;, value = pre_day)\nfeature_view_1_config = FeatureViewConfig(name = &quot;user_fea&quot;,\npartition_config=feature_view_1_partitions)\n\nfeature_view_2_partitions = PartitionConfig(name = &quot;ds&quot;, value = pre_day)\nfeature_view_2_config = FeatureViewConfig(name = &quot;seq_fea&quot;,\npartition_config=feature_view_2_partitions)\n\nfeature_view_3_partitions = PartitionConfig(name = &quot;ds&quot;, value = pre_day)\nfeature_view_3_config = FeatureViewConfig(name = &quot;item_fea&quot;,\npartition_config=feature_view_3_partitions)\n\nfeature_view_config_list = [feature_view_1_config,feature_view_2_config,feature_view_3_config]\ntrain_set_partitions = PartitionConfig(name = &quot;ds&quot;, value = cur_day)\ntrain_set_output_config = TrainSetOutputConfig(partition_config=train_set_partitions)\n\n\nmodel_name = &quot;rank_v1&quot;\ncur_model = project.get_model(model_name)\ntask = cur_model.export_train_set(label_input_config, feature_view_config_list, train_set_output_config)\ntask.wait()\nprint(&quot;task_summary = &quot;, task.task_summary)\n</para>
        /// </summary>
        [NameInMap("ExportTrainingSetTableScript")]
        [Validation(Required=false)]
        public string ExportTrainingSetTableScript { get; set; }

        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<GetModelFeatureResponseBodyFeatures> Features { get; set; }
        public class GetModelFeatureResponseBodyFeatures : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>feature2</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>feature_view_1</para>
            /// </summary>
            [NameInMap("FeatureViewName")]
            [Validation(Required=false)]
            public string FeatureViewName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>feature1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T14:46:22.227+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T14:46:22.227+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LabelPriorityLevel")]
        [Validation(Required=false)]
        public long? LabelPriorityLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>label_table1</para>
        /// </summary>
        [NameInMap("LabelTableName")]
        [Validation(Required=false)]
        public string LabelTableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model_feature1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1231243253****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Relations")]
        [Validation(Required=false)]
        public GetModelFeatureResponseBodyRelations Relations { get; set; }
        public class GetModelFeatureResponseBodyRelations : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<GetModelFeatureResponseBodyRelationsDomains> Domains { get; set; }
            public class GetModelFeatureResponseBodyRelationsDomains : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FeatureEntity</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <para>Domain ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>feature_entity_1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Links")]
            [Validation(Required=false)]
            public List<GetModelFeatureResponseBodyRelationsLinks> Links { get; set; }
            public class GetModelFeatureResponseBodyRelationsLinks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>model_feature_2</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user_id</para>
                /// </summary>
                [NameInMap("Link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>feature_entity_3</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C89F5E1-7F24-5EEC-9F05-508A39278CC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table2</para>
        /// </summary>
        [NameInMap("TrainingSetFGTable")]
        [Validation(Required=false)]
        public string TrainingSetFGTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("TrainingSetTable")]
        [Validation(Required=false)]
        public string TrainingSetTable { get; set; }

    }

}
