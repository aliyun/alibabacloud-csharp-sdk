// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetCipStatsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ByMonth")]
        [Validation(Required=false)]
        public bool? ByMonth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-11 10:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-10 10:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>253552244990701265</para>
        /// </summary>
        [NameInMap("SubUid")]
        [Validation(Required=false)]
        public string SubUid { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
