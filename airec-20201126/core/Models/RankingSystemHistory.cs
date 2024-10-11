// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class RankingSystemHistory : TeaModel {
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public RankingSystemHistoryMeta Meta { get; set; }
        public class RankingSystemHistoryMeta : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>排序模型A</para>
            /// </summary>
            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

            [NameInMap("PredictEngine")]
            [Validation(Required=false)]
            public RankingSystemHistoryMetaPredictEngine PredictEngine { get; set; }
            public class RankingSystemHistoryMetaPredictEngine : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaaa</para>
            /// </summary>
            [NameInMap("PreviousOperateId")]
            [Validation(Required=false)]
            public string PreviousOperateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>servicea</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8AC865AF-37D6-42ED-AA9A-B60D8ECDF640</para>
        /// </summary>
        [NameInMap("OperateId")]
        [Validation(Required=false)]
        public string OperateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-06T03:01:41.217Z</para>
        /// </summary>
        [NameInMap("OperateTime")]
        [Validation(Required=false)]
        public string OperateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CONF_CHANGE</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

    }

}
