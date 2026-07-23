// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The category of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DataManagement</para>
        /// </description></item>
        /// <item><description><para>Engine</para>
        /// </description></item>
        /// <item><description><para>Monitor</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataManagement</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The group of the resource.</para>
        /// <para>If <c>Category</c> is <c>DataManagement</c>, valid values are:</para>
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
        /// <para>If <c>Category</c> is <c>Engine</c>, valid values are:</para>
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
        /// <para>If <c>Category</c> is <c>Monitor</c>, valid values are:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>storage</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The type of the resource. If specified, only resources of this type are returned.</para>
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
        /// <item><description><para>Graph Compute Service</para>
        /// </description></item>
        /// <item><description><para>ApsaraDB for Redis</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
