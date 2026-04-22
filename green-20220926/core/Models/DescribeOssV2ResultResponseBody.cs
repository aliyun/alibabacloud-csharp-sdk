// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DescribeOssV2ResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeOssV2ResultResponseBodyItems> Items { get; set; }
        public class DescribeOssV2ResultResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>buckect_test</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Freeze")]
            [Validation(Required=false)]
            public bool? Freeze { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FREEZED</para>
            /// </summary>
            [NameInMap("FreezeStatus")]
            [Validation(Required=false)]
            public string FreezeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACL</para>
            /// </summary>
            [NameInMap("FreezeType")]
            [Validation(Required=false)]
            public string FreezeType { get; set; }

            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<DescribeOssV2ResultResponseBodyItemsLabelDetails> LabelDetails { get; set; }
            public class DescribeOssV2ResultResponseBodyItemsLabelDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50.00</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>politics</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("LabelDetails2")]
            [Validation(Required=false)]
            public List<DescribeOssV2ResultResponseBodyItemsLabelDetails2> LabelDetails2 { get; set; }
            public class DescribeOssV2ResultResponseBodyItemsLabelDetails2 : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>90.00</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>politics</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            [NameInMap("Labels2")]
            [Validation(Required=false)]
            public List<string> Labels2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FREEZE</para>
            /// </summary>
            [NameInMap("ManualFreezeAction")]
            [Validation(Required=false)]
            public string ManualFreezeAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-09 12:00:00</para>
            /// </summary>
            [NameInMap("ManualOperateTime")]
            [Validation(Required=false)]
            public string ManualOperateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ManualOperator")]
            [Validation(Required=false)]
            public string ManualOperator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>54416c9b159df4a60ae03c04ccb94cb5</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1713014531569_958.png</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AAAAAAAA-BBBB-CCCC-DDDD-EEEEEEEEEEEE</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel0")]
            [Validation(Required=false)]
            public string RiskLevel0 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("RiskLevel2")]
            [Validation(Required=false)]
            public string RiskLevel2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ScanResult")]
            [Validation(Required=false)]
            public string ScanResult { get; set; }

            /// <summary>
            /// <para>Service code。</para>
            /// 
            /// <b>Example:</b>
            /// <para>baselineCheck</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COPY</para>
            /// </summary>
            [NameInMap("SysDisposalStatus")]
            [Validation(Required=false)]
            public string SysDisposalStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>P_BT3FHS</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
