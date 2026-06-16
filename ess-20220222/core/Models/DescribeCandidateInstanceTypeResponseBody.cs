// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeCandidateInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of candidate ECS instance types.</para>
        /// </summary>
        [NameInMap("CandidateInstanceTypes")]
        [Validation(Required=false)]
        public List<string> CandidateInstanceTypes { get; set; }

        /// <summary>
        /// <para>A list of candidate availability zones.</para>
        /// </summary>
        [NameInMap("CandidateZoneIds")]
        [Validation(Required=false)]
        public List<string> CandidateZoneIds { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
