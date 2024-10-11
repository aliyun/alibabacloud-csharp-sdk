// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class RankingModelTemplate : TeaModel {
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public RankingModelTemplateMeta Meta { get; set; }
        public class RankingModelTemplateMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRun")]
            [Validation(Required=false)]
            public bool? AutoRun { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoRunTime")]
            [Validation(Required=false)]
            public long? AutoRunTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAY</para>
            /// </summary>
            [NameInMap("AutoRunType")]
            [Validation(Required=false)]
            public string AutoRunType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanDeploy")]
            [Validation(Required=false)]
            public bool? CanDeploy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>train_config {}</para>
            /// </summary>
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public string Conf { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NOT_DEPLOYED</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-06T03:01:41.217Z</para>
            /// </summary>
            [NameInMap("LastEditTime")]
            [Validation(Required=false)]
            public string LastEditTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>模型A</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::111:role/aliyunodpspaidefaultrole</para>
            /// </summary>
            [NameInMap("OssArn")]
            [Validation(Required=false)]
            public string OssArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bucket-a</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-beijing.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("SampleId")]
            [Validation(Required=false)]
            public string SampleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>样本1</para>
            /// </summary>
            [NameInMap("SampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SampleTimeWindow")]
            [Validation(Required=false)]
            public long? SampleTimeWindow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAY</para>
            /// </summary>
            [NameInMap("SampleTimeWindowType")]
            [Validation(Required=false)]
            public string SampleTimeWindowType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MULTI_TOWER</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRAINING_SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a-a-a</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("VersionNum")]
        [Validation(Required=false)]
        public long? VersionNum { get; set; }

    }

}
