// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskByKeyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageBuildRiskByKeyResponseBodyData Data { get; set; }
        public class DescribeImageBuildRiskByKeyResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageBuildRiskByKeyResponseBodyDataList> List { get; set; }
            public class DescribeImageBuildRiskByKeyResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>do not use root user</para>
                /// </summary>
                [NameInMap("Advice")]
                [Validation(Required=false)]
                public string Advice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>the root user has excessive permissions</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user root</para>
                /// </summary>
                [NameInMap("LayerCmd")]
                [Validation(Required=false)]
                public string LayerCmd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6ec898e6274f942e0e4a053eff1c3119026a6704e56cff206b2cec71f636****</para>
                /// </summary>
                [NameInMap("LayerDigest")]
                [Validation(Required=false)]
                public string LayerDigest { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>the root user has excessive permissions</para>
                /// </summary>
                [NameInMap("Promt")]
                [Validation(Required=false)]
                public string Promt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClass")]
                [Validation(Required=false)]
                public string RiskClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClassName")]
                [Validation(Required=false)]
                public string RiskClassName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKey")]
                [Validation(Required=false)]
                public string RiskKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKeyName")]
                [Validation(Required=false)]
                public string RiskKeyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageBuildRiskByKeyResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageBuildRiskByKeyResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>109</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
