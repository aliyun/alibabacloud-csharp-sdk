// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSensitiveDataRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that you can configure to query the access records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dbType</description></item>
        /// <item><description>instanceName</description></item>
        /// <item><description>databaseName</description></item>
        /// <item><description>projectName</description></item>
        /// <item><description>clusterName</description></item>
        /// </list>
        /// <para>The sample value shows the parameters configured to query the access records of the sensitive data in the abc database of the Hologres instance ABC. You must configure the parameters based on the compute engine that you use in your business.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ {&quot;dbType&quot;:&quot;hologres&quot;,&quot;instanceName&quot;:&quot;ABC&quot;,&quot;databaseName&quot;:&quot;abc&quot;}, {&quot;dbType&quot;:&quot;ODPS.ODPS&quot;,&quot;projectName&quot;:&quot;adbc&quot;} ]</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
