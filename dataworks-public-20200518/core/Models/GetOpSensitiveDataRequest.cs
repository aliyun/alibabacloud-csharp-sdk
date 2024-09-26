// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpSensitiveDataRequest : TeaModel {
        /// <summary>
        /// <para>The date on which access records were generated. Specify the value in the yyyyMMdd format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20210116</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The parameters that you can configure to query the access records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dbType</description></item>
        /// <item><description>instanceName</description></item>
        /// <item><description>databaseName</description></item>
        /// <item><description>projectName</description></item>
        /// <item><description>clusterName</description></item>
        /// </list>
        /// <para>The following example shows the parameters configured to query the access records of the sensitive data in the abc database of the Hologres instance ABC: [ {&quot;dbType&quot;:&quot;hologres&quot;,&quot;instanceName&quot;:&quot;ABC&quot;,&quot;databaseName&quot;:&quot;abc&quot;} ]</para>
        /// <para>You must configure the parameters based on the compute engine that you use in your business.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[  {&quot;dbType&quot;:&quot;hologres&quot;,&quot;instanceName&quot;:&quot;ABC&quot;,&quot;databaseName&quot;:&quot;abc&quot;},  {&quot;dbType&quot;:&quot;ODPS.ODPS&quot;,&quot;projectName&quot;:&quot;adbc&quot;}  ]</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operation that is performed on the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL_SELECT: specifies the data access operation. For example, execute a SELECT statement to query data.</description></item>
        /// <item><description>TUNNEL_DOWNLOAD: specifies the data download operation. For example, run a Tunnel command to download data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL_SELECT</para>
        /// </summary>
        [NameInMap("OpType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Maximum value: 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Minimum value: 1. Maximum value: 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
