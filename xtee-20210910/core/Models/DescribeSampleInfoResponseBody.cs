// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSampleInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSampleInfoResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSampleInfoResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3144</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The sample tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>em0102</para>
            /// </summary>
            [NameInMap("sampleTags")]
            [Validation(Required=false)]
            public string SampleTags { get; set; }

            /// <summary>
            /// <para>The data sample type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHONE</para>
            /// </summary>
            [NameInMap("sampleType")]
            [Validation(Required=false)]
            public string SampleType { get; set; }

            /// <summary>
            /// <para>The sample value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17700000000</para>
            /// </summary>
            [NameInMap("sampleValue")]
            [Validation(Required=false)]
            public string SampleValue { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753804800000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
