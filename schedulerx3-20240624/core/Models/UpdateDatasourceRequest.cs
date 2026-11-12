// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateDatasourceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The datasource connection parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;host&quot;:&quot;rm-bp1f03mxxxxx.mysql.rds.aliyuncs.com&quot;,&quot;port&quot;:3306,&quot;userName&quot;:&quot;test01&quot;,&quot;database&quot;:&quot;test01&quot;,&quot;other&quot;:{&quot;useSSL&quot;:&quot;false&quot;}}</para>
        /// </summary>
        [NameInMap("ConnectionParams")]
        [Validation(Required=false)]
        public string ConnectionParams { get; set; }

        /// <summary>
        /// <para>The datasource ID. You can obtain this ID by calling the ListDatasources operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public long? DatasourceId { get; set; }

        /// <summary>
        /// <para>The datasource description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The datasource name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bill pull - Alipay group buying</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The database password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F9e9@a69c!e18b569c8</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
