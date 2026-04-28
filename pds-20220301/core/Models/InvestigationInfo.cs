// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class InvestigationInfo : TeaModel {
        /// <summary>
        /// <para>The status of the review.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The review is not performed.</description></item>
        /// <item><description>1: The review is not supported.</description></item>
        /// <item><description>2: The review fails.</description></item>
        /// <item><description>3: The review is in progress.</description></item>
        /// <item><description>4: The review is complete.</description></item>
        /// <item><description>5: Penalty methods are applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The recommended operation provided by the review.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pass: The review is passed..</description></item>
        /// <item><description>block: The review is not passed. It is recommended to limit the use of the image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        /// <summary>
        /// <para>Video review information</para>
        /// </summary>
        [NameInMap("video_detail")]
        [Validation(Required=false)]
        public InvestigationInfoVideoDetail VideoDetail { get; set; }
        public class InvestigationInfoVideoDetail : TeaModel {
            /// <summary>
            /// <para>Violation frame information</para>
            /// </summary>
            [NameInMap("block_frames")]
            [Validation(Required=false)]
            public List<InvestigationInfoVideoDetailBlockFrames> BlockFrames { get; set; }
            public class InvestigationInfoVideoDetailBlockFrames : TeaModel {
                /// <summary>
                /// <para>Category of review results</para>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Time (in seconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("offset")]
                [Validation(Required=false)]
                public long? Offset { get; set; }

                /// <summary>
                /// <para>The confidence level. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.1</para>
                /// </summary>
                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

            }

        }

    }

}
