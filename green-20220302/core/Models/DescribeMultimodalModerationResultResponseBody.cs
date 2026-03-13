// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeMultimodalModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMultimodalModerationResultResponseBodyData Data { get; set; }
        public class DescribeMultimodalModerationResultResponseBodyData : TeaModel {
            [NameInMap("CommentDatas")]
            [Validation(Required=false)]
            public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatas> CommentDatas { get; set; }
            public class DescribeMultimodalModerationResultResponseBodyDataCommentDatas : TeaModel {
                [NameInMap("CommentDatas")]
                [Validation(Required=false)]
                public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatas> CommentDatas { get; set; }
                public class DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatas : TeaModel {
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatasResults> Results { get; set; }
                    public class DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatasResults : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>violent_explosion</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatasResults> Results { get; set; }
                public class DescribeMultimodalModerationResultResponseBodyDataCommentDatasResults : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("MainData")]
            [Validation(Required=false)]
            public DescribeMultimodalModerationResultResponseBodyDataMainData MainData { get; set; }
            public class DescribeMultimodalModerationResultResponseBodyDataMainData : TeaModel {
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DescribeMultimodalModerationResultResponseBodyDataMainDataResults> Results { get; set; }
                public class DescribeMultimodalModerationResultResponseBodyDataMainDataResults : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
