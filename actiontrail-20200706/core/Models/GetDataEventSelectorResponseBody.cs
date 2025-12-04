// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetDataEventSelectorResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]},&quot;ReadWriteType&quot;:&quot;All&quot;,&quot;ServiceName&quot;:&quot;Oss&quot;}]</para>
        /// </summary>
        [NameInMap("DataEventSelectors")]
        [Validation(Required=false)]
        public string DataEventSelectors { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTrailAllRegion")]
        [Validation(Required=false)]
        public bool? IsTrailAllRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90771C32-635B-529C-950C-75A9607D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfigs")]
        [Validation(Required=false)]
        public List<GetDataEventSelectorResponseBodySlsDeliveryConfigs> SlsDeliveryConfigs { get; set; }
        public class GetDataEventSelectorResponseBodySlsDeliveryConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-18T03:25:36Z</para>
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

    }

}
