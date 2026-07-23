// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateInstanceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The resource category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DataManagement</para>
        /// </description></item>
        /// <item><description><para>Engine</para>
        /// </description></item>
        /// <item><description><para>Monitor</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataManagement</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The resource group.</para>
        /// <para>If the resource category is DataManagement, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>storage</para>
        /// </description></item>
        /// <item><description><para>modelpipeline</para>
        /// </description></item>
        /// <item><description><para>datastorage</para>
        /// </description></item>
        /// <item><description><para>modeltrain</para>
        /// </description></item>
        /// </list>
        /// <para>If the resource category is Engine, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>feature</para>
        /// </description></item>
        /// <item><description><para>predict</para>
        /// </description></item>
        /// <item><description><para>recall</para>
        /// </description></item>
        /// <item><description><para>recengine</para>
        /// </description></item>
        /// </list>
        /// <para>If the resource category is Monitor, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>logs</para>
        /// </description></item>
        /// <item><description><para>logsback</para>
        /// </description></item>
        /// <item><description><para>coldstart</para>
        /// </description></item>
        /// <item><description><para>deploy</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>storage</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Hologres</para>
        /// </description></item>
        /// <item><description><para>EAS</para>
        /// </description></item>
        /// <item><description><para>BE</para>
        /// </description></item>
        /// <item><description><para>Rec</para>
        /// </description></item>
        /// <item><description><para>Platform</para>
        /// </description></item>
        /// <item><description><para>SLS</para>
        /// </description></item>
        /// <item><description><para>DataHub</para>
        /// </description></item>
        /// <item><description><para>ApsaraMQ for Kafka</para>
        /// </description></item>
        /// <item><description><para>Realtime Compute for Apache Flink</para>
        /// </description></item>
        /// <item><description><para>ACR</para>
        /// </description></item>
        /// <item><description><para>OSS</para>
        /// </description></item>
        /// <item><description><para>DataWorks</para>
        /// </description></item>
        /// <item><description><para>PAI</para>
        /// </description></item>
        /// <item><description><para>MaxCompute</para>
        /// </description></item>
        /// <item><description><para>Graph Compute</para>
        /// </description></item>
        /// <item><description><para>ApsaraDB for Redis</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The resource URI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket-test-123</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
