// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConvertableEcuRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster. You can call the ListCluster operation to query the cluster ID. For more information, see <a href="https://help.aliyun.com/document_detail/154995.html">ListCluster</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3e3f77b-462e-<b><b>-</b></b>-bec8727a****</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
