// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskByKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageBuildRiskByKeyResponseBodyData Data { get; set; }
        public class DescribeImageBuildRiskByKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The risks.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageBuildRiskByKeyResponseBodyDataList> List { get; set; }
            public class DescribeImageBuildRiskByKeyResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The suggestion on how to handle the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>do not use root user</para>
                /// </summary>
                [NameInMap("Advice")]
                [Validation(Required=false)]
                public string Advice { get; set; }

                /// <summary>
                /// <para>The description of the suggestion on how to handle the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>the root user has excessive permissions</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The image build command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user root</para>
                /// </summary>
                [NameInMap("LayerCmd")]
                [Validation(Required=false)]
                public string LayerCmd { get; set; }

                /// <summary>
                /// <para>The digest of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6ec898e6274f942e0e4a053eff1c3119026a6704e56cff206b2cec71f636****</para>
                /// </summary>
                [NameInMap("LayerDigest")]
                [Validation(Required=false)]
                public string LayerDigest { get; set; }

                /// <summary>
                /// <para>The prompt message on the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>the root user has excessive permissions</para>
                /// </summary>
                [NameInMap("Promt")]
                [Validation(Required=false)]
                public string Promt { get; set; }

                /// <summary>
                /// <para>The type key of the risk rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClass")]
                [Validation(Required=false)]
                public string RiskClass { get; set; }

                /// <summary>
                /// <para>The type name of the risk rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClassName")]
                [Validation(Required=false)]
                public string RiskClassName { get; set; }

                /// <summary>
                /// <para>The key of the risk rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKey")]
                [Validation(Required=false)]
                public string RiskKey { get; set; }

                /// <summary>
                /// <para>The name of the risk rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKeyName")]
                [Validation(Required=false)]
                public string RiskKeyName { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>low</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageBuildRiskByKeyResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageBuildRiskByKeyResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number. Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
                /// <remarks>
                /// <para> We recommend that you do not leave this parameter empty.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>109</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
