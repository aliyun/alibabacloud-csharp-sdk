// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaInfoJobsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7b38a5d86f1e47838927b6e7ccb11cbe</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateTimeDesc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
