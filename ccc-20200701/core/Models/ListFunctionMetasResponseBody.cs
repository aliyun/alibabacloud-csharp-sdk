// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListFunctionMetasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFunctionMetasResponseBodyData Data { get; set; }
        public class ListFunctionMetasResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListFunctionMetasResponseBodyDataList> List { get; set; }
            public class ListFunctionMetasResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>15772400000****</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>王先生</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("FailoverRegion")]
                [Validation(Required=false)]
                public string FailoverRegion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FailoverRegionWeight")]
                [Validation(Required=false)]
                public double? FailoverRegionWeight { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4bbcd898-xxxxx-47e5-85bb-718166</para>
                /// </summary>
                [NameInMap("FunctionMetaId")]
                [Validation(Required=false)]
                public string FunctionMetaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sql_hra</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxx">http://xxxx</a></para>
                /// </summary>
                [NameInMap("HttpTriggerUrl")]
                [Validation(Required=false)]
                public string HttpTriggerUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>logical</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url_detection_pro</para>
                /// </summary>
                [NameInMap("Service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26D1277F-55BF-453E-A6B2-02B7E6F97699</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
