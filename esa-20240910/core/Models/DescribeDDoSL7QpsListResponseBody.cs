// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSL7QpsListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public int? DataInterval { get; set; }

        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeDDoSL7QpsListResponseBodyDataModule> DataModule { get; set; }
        public class DescribeDDoSL7QpsListResponseBodyDataModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Attack")]
            [Validation(Required=false)]
            public long? Attack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Normal")]
            [Validation(Required=false)]
            public long? Normal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-19T16:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-19T19:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86510927836942****</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-19T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
