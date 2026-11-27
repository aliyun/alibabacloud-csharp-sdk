// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the channel type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("ChannelTypeName")]
        [Validation(Required=false)]
        public string ChannelTypeName { get; set; }

        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The quality inspection task data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityResultResponseBodyData Data { get; set; }
        public class GetQualityResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of data details.</para>
            /// </summary>
            [NameInMap("QualityResultResponseList")]
            [Validation(Required=false)]
            public List<GetQualityResultResponseBodyDataQualityResultResponseList> QualityResultResponseList { get; set; }
            public class GetQualityResultResponseBodyDataQualityResultResponseList : TeaModel {
                /// <summary>
                /// <para>The channel type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Hotline.</description></item>
                /// <item><description><b>2</b>: Online.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>The name of the channel type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Online</para>
                /// </summary>
                [NameInMap("ChannelTypeName")]
                [Validation(Required=false)]
                public string ChannelTypeName { get; set; }

                /// <summary>
                /// <para>The ID of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automated skill group</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The details of the quality inspection result, including the hit keywords and context chat information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("HitDetail")]
                [Validation(Required=false)]
                public string HitDetail { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HitStatus")]
                [Validation(Required=false)]
                public bool? HitStatus { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xspace commercial service</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Anonymous member</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>The ID of the quality inspection task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15977801</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The name of the quality inspection task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automated quality inspection task</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The ID of the quality inspection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5369</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the quality inspection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automated quality inspection rule</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The ID of the customer service representative.</para>
                /// 
                /// <b>Example:</b>
                /// <para>555555</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public string ServicerId { get; set; }

                /// <summary>
                /// <para>The name of the customer service representative.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Liu Test</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20928756</para>
                /// </summary>
                [NameInMap("TouchId")]
                [Validation(Required=false)]
                public string TouchId { get; set; }

                /// <summary>
                /// <para>The start time of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-26 12:11:06</para>
                /// </summary>
                [NameInMap("TouchStartTime")]
                [Validation(Required=false)]
                public string TouchStartTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>84</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
