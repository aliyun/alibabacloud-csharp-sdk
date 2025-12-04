// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDataEventSelectorsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataEventSelectorsResponseBodyData Data { get; set; }
        public class ListDataEventSelectorsResponseBodyData : TeaModel {
            [NameInMap("DataEventSelectorInfos")]
            [Validation(Required=false)]
            public List<ListDataEventSelectorsResponseBodyDataDataEventSelectorInfos> DataEventSelectorInfos { get; set; }
            public class ListDataEventSelectorsResponseBodyDataDataEventSelectorInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]},&quot;ReadWriteType&quot;:&quot;All&quot;,&quot;ServiceName&quot;:&quot;Oss&quot;}]</para>
                /// </summary>
                [NameInMap("EventSelectors")]
                [Validation(Required=false)]
                public string EventSelectors { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsTrailAllRegion")]
                [Validation(Required=false)]
                public bool? IsTrailAllRegion { get; set; }

                [NameInMap("SlsDeliveryConfigs")]
                [Validation(Required=false)]
                public List<ListDataEventSelectorsResponseBodyDataDataEventSelectorInfosSlsDeliveryConfigs> SlsDeliveryConfigs { get; set; }
                public class ListDataEventSelectorsResponseBodyDataDataEventSelectorInfosSlsDeliveryConfigs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-09-30T16:11Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LogServiceException</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>acs:log:cn-shanghai:159498693826****:project/actiontrail-log-159498693826****-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("RegionSlsProjectArn")]
                    [Validation(Required=false)]
                    public string RegionSlsProjectArn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("TrailRegion")]
                    [Validation(Required=false)]
                    public string TrailRegion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:actiontrail:cn-shanghai:159498693826****:trail/trail-name</para>
                /// </summary>
                [NameInMap("TrailArn")]
                [Validation(Required=false)]
                public string TrailArn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>trail-name</para>
                /// </summary>
                [NameInMap("TrailName")]
                [Validation(Required=false)]
                public string TrailName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VjE6bHJlTGoxdm1M****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8A74FD2E-A9B9-461C-BCE9-D9668DF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
