// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetIssueShrinkRequest : TeaModel {
        /// <summary>
        /// <para>AppKey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233588686</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h5Resource</para>
        /// </summary>
        [NameInMap("BizModule")]
        [Validation(Required=false)]
        public string BizModule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2963475858785631</para>
        /// </summary>
        [NameInMap("DigestHash")]
        [Validation(Required=false)]
        public string DigestHash { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h5</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public GetIssueShrinkRequestTimeRange TimeRange { get; set; }
        public class GetIssueShrinkRequestTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-23T02:12:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Host</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public int? Granularity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>minute</para>
            /// </summary>
            [NameInMap("GranularityUnit")]
            [Validation(Required=false)]
            public string GranularityUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-18 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
