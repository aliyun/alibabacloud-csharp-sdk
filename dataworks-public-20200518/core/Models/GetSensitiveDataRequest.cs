// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSensitiveDataRequest : TeaModel {
        /// <summary>
        /// <para>The condition settings for retrieving access records. Optional parameters:</para>
        /// <list type="bullet">
        /// <item><description>dbType: The data type.</description></item>
        /// <item><description>instanceName: The instance name.</description></item>
        /// <item><description>databaseName: The database name.</description></item>
        /// <item><description>projectName: The project name.</description></item>
        /// <item><description>clusterName: The cluster name.</description></item>
        /// </list>
        /// <para>Example: Retrieve sensitive data access records for the abc database of the ABC instance in Hologres. Configure the parameters based on the engine used in your business.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ {&quot;dbType&quot;:&quot;hologres&quot;,&quot;instanceName&quot;:&quot;ABC&quot;,&quot;databaseName&quot;:&quot;abc&quot;}, {&quot;dbType&quot;:&quot;ODPS.ODPS&quot;,&quot;projectName&quot;:&quot;adbc&quot;} ]</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Maximum value: 1000.</para>
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
