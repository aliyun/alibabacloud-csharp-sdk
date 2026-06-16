// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosEventListResponseBody : TeaModel {
        [NameInMap("DdosEventList")]
        [Validation(Required=false)]
        public DescribeDdosEventListResponseBodyDdosEventList DdosEventList { get; set; }
        public class DescribeDdosEventListResponseBodyDdosEventList : TeaModel {
            [NameInMap("DdosEvent")]
            [Validation(Required=false)]
            public List<DescribeDdosEventListResponseBodyDdosEventListDdosEvent> DdosEvent { get; set; }
            public class DescribeDdosEventListResponseBodyDdosEventListDdosEvent : TeaModel {
                [NameInMap("DdosStatus")]
                [Validation(Required=false)]
                public string DdosStatus { get; set; }

                [NameInMap("DdosType")]
                [Validation(Required=false)]
                public string DdosType { get; set; }

                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public long? DelayTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("UnBlackholeTime")]
                [Validation(Required=false)]
                public long? UnBlackholeTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC0907F8-A9F3-5E11-977B-D59CD98C64ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of DDoS attack events found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
