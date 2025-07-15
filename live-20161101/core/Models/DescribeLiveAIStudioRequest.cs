// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAIStudioRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual studio template that you want to query. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbe61b87-db9a-448f-8757-a875edb3f944</para>
        /// </summary>
        [NameInMap("StudioId")]
        [Validation(Required=false)]
        public string StudioId { get; set; }

        /// <summary>
        /// <para>The name of the virtual studio template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub02</para>
        /// </summary>
        [NameInMap("StudioName")]
        [Validation(Required=false)]
        public string StudioName { get; set; }

    }

}
