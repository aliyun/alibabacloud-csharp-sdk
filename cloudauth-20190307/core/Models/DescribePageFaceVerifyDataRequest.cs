// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribePageFaceVerifyDataRequest : TeaModel {
        /// <summary>
        /// <para>Current page number, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>Required, end time, format is yyyy-MM-dd, default is yyyy-MM-dd 00:00:00, the query interval cannot exceed 90 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-30</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Number of items per page, default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PLUS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36**01</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Required, start time, format is yyyy-MM-dd, default is yyyy-MM-dd 00:00:00, the query interval cannot exceed 90 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-10</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
