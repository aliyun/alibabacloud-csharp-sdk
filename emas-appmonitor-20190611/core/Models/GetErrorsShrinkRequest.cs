// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetErrorsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>appKey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24780725</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crash</para>
        /// </summary>
        [NameInMap("BizModule")]
        [Validation(Required=false)]
        public string BizModule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-3481243636390427020</para>
        /// </summary>
        [NameInMap("DigestHash")]
        [Validation(Required=false)]
        public string DigestHash { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public GetErrorsShrinkRequestTimeRange TimeRange { get; set; }
        public class GetErrorsShrinkRequestTimeRange : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740499200000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1739894400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>utdid</para>
        /// 
        /// <b>Example:</b>
        /// <para>Z70g6V/MXJ8DABtD53eHzn4X</para>
        /// </summary>
        [NameInMap("Utdid")]
        [Validation(Required=false)]
        public string Utdid { get; set; }

    }

}
