// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUrlModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUrlModerationResultResponseBodyData Data { get; set; }
        public class DescribeUrlModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value of the dataId parameter passed in the API request. This field is not returned if the parameter is not passed in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeUrlModerationResultResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <para>The ICP filing number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ICP备123456789</para>
                /// </summary>
                [NameInMap("IcpNo")]
                [Validation(Required=false)]
                public string IcpNo { get; set; }

                /// <summary>
                /// <para>The ICP filing type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>企业</para>
                /// </summary>
                [NameInMap("IcpType")]
                [Validation(Required=false)]
                public string IcpType { get; set; }

                /// <summary>
                /// <para>The website type</para>
                /// 
                /// <b>Example:</b>
                /// <para>game</para>
                /// </summary>
                [NameInMap("SiteType")]
                [Validation(Required=false)]
                public string SiteType { get; set; }

            }

            /// <summary>
            /// <para>The ReqId field returned by the asynchronous URL moderation operation</para>
            /// 
            /// <b>Example:</b>
            /// <para>B0963D30-BAB4-562F-9ED0-7A23AEC51C7C</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// <para>The returned collection.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeUrlModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The confidence score, ranging from 0 to 100, with two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The label returned after URL moderation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sexual_url</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01F9144A-2088-5D87-935B-2DB865284B1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
