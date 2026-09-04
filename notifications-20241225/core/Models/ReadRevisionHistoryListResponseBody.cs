// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadRevisionHistoryListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned by the system. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadRevisionHistoryListResponseBodyData Data { get; set; }
        public class ReadRevisionHistoryListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page of data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAT0x7j2M1Og+SpZ8n4WEjfo=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>A single row of returned data.</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<ReadRevisionHistoryListResponseBodyDataRows> Rows { get; set; }
            public class ReadRevisionHistoryListResponseBodyDataRows : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1305851476425884</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The event type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod_edu_content</para>
                /// </summary>
                [NameInMap("CategoryCode")]
                [Validation(Required=false)]
                public string CategoryCode { get; set; }

                /// <summary>
                /// <para>The channel group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>base</para>
                /// </summary>
                [NameInMap("ChannelGroupCode")]
                [Validation(Required=false)]
                public string ChannelGroupCode { get; set; }

                /// <summary>
                /// <para>The modified value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;channelType&quot;: &quot;sms&quot;,
                ///         &quot;checkedState&quot;: &quot;YES&quot;
                ///     },
                ///     {
                ///         &quot;channelType&quot;: &quot;pmsg&quot;,
                ///         &quot;checkedState&quot;: &quot;NO&quot;
                ///     },
                ///     {
                ///         &quot;channelType&quot;: &quot;email&quot;,
                ///         &quot;checkedState&quot;: &quot;NO&quot;
                ///     }
                /// ]</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <para>The revision item code. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>receive_channel</para>
                /// </summary>
                [NameInMap("OperationItemCode")]
                [Validation(Required=false)]
                public string OperationItemCode { get; set; }

                /// <summary>
                /// <para>The revision item name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Reception channel</para>
                /// </summary>
                [NameInMap("OperationItemName")]
                [Validation(Required=false)]
                public string OperationItemName { get; set; }

                /// <summary>
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1743583672981</para>
                /// </summary>
                [NameInMap("OperationTimestamp")]
                [Validation(Required=false)]
                public long? OperationTimestamp { get; set; }

                /// <summary>
                /// <para>The IP address of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("OperatorIp")]
                [Validation(Required=false)]
                public string OperatorIp { get; set; }

                /// <summary>
                /// <para>The name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1662077279821892</para>
                /// </summary>
                [NameInMap("OperatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <para>The UID of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1062132414049864</para>
                /// </summary>
                [NameInMap("OperatorUid")]
                [Validation(Required=false)]
                public long? OperatorUid { get; set; }

                /// <summary>
                /// <para>The original value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;channelType&quot;: &quot;sms&quot;,
                ///         &quot;checkedState&quot;: &quot;NO&quot;
                ///     },
                ///     {
                ///         &quot;channelType&quot;: &quot;pmsg&quot;,
                ///         &quot;checkedState&quot;: &quot;NO&quot;
                ///     },
                ///     {
                ///         &quot;channelType&quot;: &quot;email&quot;,
                ///         &quot;checkedState&quot;: &quot;NO&quot;
                ///     }
                /// ]</para>
                /// </summary>
                [NameInMap("OriginalValue")]
                [Validation(Required=false)]
                public string OriginalValue { get; set; }

                /// <summary>
                /// <para>The pagination information.</para>
                /// </summary>
                [NameInMap("PageSpec")]
                [Validation(Required=false)]
                public ReadRevisionHistoryListResponseBodyDataRowsPageSpec PageSpec { get; set; }
                public class ReadRevisionHistoryListResponseBodyDataRowsPageSpec : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of entries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxResults")]
                    [Validation(Required=false)]
                    public int? MaxResults { get; set; }

                    /// <summary>
                    /// <para>The token for the next page of data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AAAAAT0x7j2M1Og+SpZ8n4WEjfo=</para>
                    /// </summary>
                    [NameInMap("NextToken")]
                    [Validation(Required=false)]
                    public string NextToken { get; set; }

                }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Remarks")]
                [Validation(Required=false)]
                public string Remarks { get; set; }

            }

            /// <summary>
            /// <para>The total number of messages in the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xx</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The message returned when the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5F62766-1C2F-1F56-A39D-63E3D30F0633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
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
