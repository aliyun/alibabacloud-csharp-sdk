// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class RankingSystem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NOT_APPLIED</para>
        /// </summary>
        [NameInMap("ApplyStatus")]
        [Validation(Required=false)]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NOT_DEPLOYED</para>
        /// </summary>
        [NameInMap("DeployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public RankingSystemMeta Meta { get; set; }
        public class RankingSystemMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoDeploy")]
            [Validation(Required=false)]
            public bool? AutoDeploy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("AutoDeployAuc")]
            [Validation(Required=false)]
            public string AutoDeployAuc { get; set; }

            [NameInMap("Conf")]
            [Validation(Required=false)]
            public string Conf { get; set; }

            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>模型A_T1638964800000</para>
            /// </summary>
            [NameInMap("ModelVersionName")]
            [Validation(Required=false)]
            public string ModelVersionName { get; set; }

            [NameInMap("PredictEngine")]
            [Validation(Required=false)]
            public RankingSystemMetaPredictEngine PredictEngine { get; set; }
            public class RankingSystemMetaPredictEngine : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eas-oljkkdrggxhx7eizjd</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EAS</para>
            /// </summary>
            [NameInMap("PredictEngineType")]
            [Validation(Required=false)]
            public string PredictEngineType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a-a-a</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>servicea</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SceneIdList")]
        [Validation(Required=false)]
        public List<long?> SceneIdList { get; set; }

    }

}
