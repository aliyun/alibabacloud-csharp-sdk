// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDataEventSelectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataEventSelectorsResponseBodyData Data { get; set; }
        public class ListDataEventSelectorsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of data event selectors.</para>
            /// </summary>
            [NameInMap("DataEventSelectorInfos")]
            [Validation(Required=false)]
            public List<ListDataEventSelectorsResponseBodyDataDataEventSelectorInfos> DataEventSelectorInfos { get; set; }
            public class ListDataEventSelectorsResponseBodyDataDataEventSelectorInfos : TeaModel {
                /// <summary>
                /// <para>The configuration of the data event selector. This parameter is a JSON array that can contain a maximum of 20 elements.</para>
                /// <para>Each element in the JSON array includes the following fields:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ServiceName</c>: The name of the Alibaba Cloud service that supports data events.</para>
                /// </description></item>
                /// <item><description><para><c>ReadWriteType</c>: The type of data event. Valid values: Read, Write, and All.</para>
                /// </description></item>
                /// <item><description><para><c>EventName</c>: This field contains the <c>Equals</c> and <c>NotEquals</c> subfields.</para>
                /// <para>For example, the following configuration specifies that only <c>GetObject</c>, <c>CopyObject</c>, and <c>AppendObject</c>events are delivered:</para>
                /// <para><c>{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]}}</c></para>
                /// <para>If you specify <c>NotEquals</c>, events other than <c>GetObject</c>, <c>CopyObject</c>, and <c>AppendObject</c> are delivered.</para>
                /// </description></item>
                /// <item><description><para><c>ResourceArn</c>: This field also contains the <c>Equals</c> and <c>NotEquals</c> subfields, similar to <c>EventName</c>. For example:</para>
                /// <para><c>{&quot;ResourceArn&quot;:{&quot;Equals&quot;:[arn1,...,arnx]}}</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]},&quot;ReadWriteType&quot;:&quot;All&quot;,&quot;ServiceName&quot;:&quot;Oss&quot;}]</para>
                /// </summary>
                [NameInMap("EventSelectors")]
                [Validation(Required=false)]
                public string EventSelectors { get; set; }

                /// <summary>
                /// <para>Specifies whether the trail tracks data events in all regions.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
                /// </description></item>
                /// <item><description><para>false</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsTrailAllRegion")]
                [Validation(Required=false)]
                public bool? IsTrailAllRegion { get; set; }

                /// <summary>
                /// <para>The list of configurations for delivering events to Simple Log Service (SLS).</para>
                /// </summary>
                [NameInMap("SlsDeliveryConfigs")]
                [Validation(Required=false)]
                public List<ListDataEventSelectorsResponseBodyDataDataEventSelectorInfosSlsDeliveryConfigs> SlsDeliveryConfigs { get; set; }
                public class ListDataEventSelectorsResponseBodyDataDataEventSelectorInfosSlsDeliveryConfigs : TeaModel {
                    /// <summary>
                    /// <para>The time when the trail was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-09-30T16:11Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The error code returned if the resource initialization fails.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LogServiceException</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error message returned if the resource initialization fails.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RequestError Web request failed.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the SLS project in the region where events are delivered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:log:cn-shanghai:159498693826****:project/actiontrail-log-159498693826****-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("RegionSlsProjectArn")]
                    [Validation(Required=false)]
                    public string RegionSlsProjectArn { get; set; }

                    /// <summary>
                    /// <para>The initialization status of the tracked resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The region of the trail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("TrailRegion")]
                    [Validation(Required=false)]
                    public string TrailRegion { get; set; }

                }

                /// <summary>
                /// <para>The ARN of the trail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:actiontrail:cn-shanghai:159498693826****:trail/trail-name</para>
                /// </summary>
                [NameInMap("TrailArn")]
                [Validation(Required=false)]
                public string TrailArn { get; set; }

                /// <summary>
                /// <para>The name of the trail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trail-name</para>
                /// </summary>
                [NameInMap("TrailName")]
                [Validation(Required=false)]
                public string TrailName { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VjE6bHJlTGoxdm1M****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A74FD2E-A9B9-461C-BCE9-D9668DF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
