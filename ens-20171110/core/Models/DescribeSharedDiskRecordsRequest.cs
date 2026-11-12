// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSharedDiskRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The shared disk IDs.</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// <para>The billing end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-30T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The namespaces.</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The page number for the paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region IDs.</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The SDG IDs.</para>
        /// </summary>
        [NameInMap("SdgIds")]
        [Validation(Required=false)]
        public List<string> SdgIds { get; set; }

        /// <summary>
        /// <para>The billing start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-21T10:22:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
