// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSupportLinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud DNS lines.</para>
        /// </summary>
        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeSupportLinesResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeSupportLinesResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeSupportLinesResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeSupportLinesResponseBodyRecordLinesRecordLine : TeaModel {
                /// <summary>
                /// <para>The code of the parent line. Currently, no data is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unicom</para>
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// <para>The code of the child line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn_unicom_shanxi</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The display name of the line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China Unicom</para>
                /// </summary>
                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                /// <summary>
                /// <para>The name of the child line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China Unicom_Shanxi</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CFDA0830-7D6E-4C13-8632-B57C7EDCF079</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
