// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteUserDefineRegionRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the custom namespace. You can call the ListUserDefineRegion operation to query the ID. For more information, see <a href="https://help.aliyun.com/document_detail/149377.html">ListUserDefineRegion</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2564</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The tag of the custom namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>regiontag</para>
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

    }

}
