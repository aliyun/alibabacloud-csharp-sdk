// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataBatchIngestionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled。</para>
        /// </summary>
        [NameInMap("AutoScanNew")]
        [Validation(Required=false)]
        public string AutoScanNew { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>full。</para>
        /// </summary>
        [NameInMap("DataBatchIngestionMode")]
        [Validation(Required=false)]
        public string DataBatchIngestionMode { get; set; }

        [NameInMap("DataIngestionIds")]
        [Validation(Required=false)]
        public List<string> DataIngestionIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true。</para>
        /// </summary>
        [NameInMap("DataSourceRecognizeEnabled")]
        [Validation(Required=false)]
        public bool? DataSourceRecognizeEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public List<long?> LogUserIds { get; set; }

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
