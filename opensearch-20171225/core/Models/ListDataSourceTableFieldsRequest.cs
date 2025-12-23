// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListDataSourceTableFieldsRequest : TeaModel {
        /// <summary>
        /// <para>The parameters of the data source. The value of the params parameter is a JSON string. The value must be URL-encoded.</para>
        /// <para>Different types of data sources use different parameters. For more information, see the following sections of the &quot;DataSource&quot; topic:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/170005.html">rds</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/170005.html">polardb</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/170005.html">odps</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/173627.html">mysql</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/173627.html">drds</a></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
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

    }

}
