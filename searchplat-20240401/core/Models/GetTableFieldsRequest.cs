// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetTableFieldsRequest : TeaModel {
        /// <summary>
        /// <para>The data source parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;accessKeySecret&quot;: &quot;sk&quot;,
        /// &quot;accessKey&quot;: &quot;ak&quot;,
        /// &quot;projectName&quot;: &quot;test_name&quot;,
        /// &quot;tableName&quot;: &quot;test_table&quot;,
        /// &quot;partition&quot;: &quot;20240904&quot;
        /// }</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the original field types of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("rawType")]
        [Validation(Required=false)]
        public bool? RawType { get; set; }

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
