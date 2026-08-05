// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetTablesRequest : TeaModel {
        /// <summary>
        /// <para>The data source parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;instanceId&quot;: &quot;instance_id&quot;,
        ///     &quot;dbName&quot;: &quot;db_name&quot;,
        ///     &quot;dbUser&quot;: &quot;db_user&quot;,
        ///     &quot;dbPassword&quot;: &quot;passwoed&quot;
        /// }</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
