// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataIngestionsShrinkRequest : TeaModel {
        [NameInMap("DataIngestionIds")]
        [Validation(Required=false)]
        public string DataIngestionIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled。</para>
        /// </summary>
        [NameInMap("DataIngestionStatus")]
        [Validation(Required=false)]
        public string DataIngestionStatus { get; set; }

        [NameInMap("DataIngestionTemplateIds")]
        [Validation(Required=false)]
        public string DataIngestionTemplateIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas。</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
