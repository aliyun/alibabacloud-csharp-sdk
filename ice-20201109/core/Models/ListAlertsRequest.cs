// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAlertsRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-22T16:10:45Z</para>
        /// </summary>
        [NameInMap("GmtEnd")]
        [Validation(Required=false)]
        public string GmtEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-21T16:10:45Z</para>
        /// </summary>
        [NameInMap("GmtStart")]
        [Validation(Required=false)]
        public string GmtStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ims:mediaweaver:<regionId>:<userId>:vodSource/mySourceLocation/MySource</para>
        /// </summary>
        [NameInMap("ResourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortByModifiedTime")]
        [Validation(Required=false)]
        public string SortByModifiedTime { get; set; }

    }

}
