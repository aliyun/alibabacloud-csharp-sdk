// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataRequest : TeaModel {
        /// <summary>
        /// <para>The date for which to retrieve access records. Format: yyyyMMdd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20210221</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The condition settings for retrieving access records. Optional parameters are as follows:</para>
        /// <list type="bullet">
        /// <item><description>dbType: The database type.</description></item>
        /// <item><description>instanceName: The instance name.</description></item>
        /// <item><description>databaseName: The database name.</description></item>
        /// <item><description>projectName: The project name.</description></item>
        /// <item><description>clusterName: The cluster name.</description></item>
        /// </list>
        /// <para>Example of retrieving sensitive data access records for the abc database of the ABC instance in Hologres:
        /// [  {&quot;dbType&quot;:&quot;hologres&quot;,&quot;instanceName&quot;:&quot;ABC&quot;,&quot;databaseName&quot;:&quot;abc&quot;} ]</para>
        /// <para>Configure the parameters based on the engine used in your business.</para>
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
        /// <para>The number of entries to return on each page. Maximum value: 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The method used to identify the risk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manual identification.</description></item>
        /// <item><description>The name of the risk rule. You can obtain the name on the Risk Identification Management page in Data Security Guard of DataWorks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual identification</para>
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

    }

}
