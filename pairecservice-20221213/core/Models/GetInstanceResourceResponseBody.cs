// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetInstanceResourceResponseBody : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>DataManagement</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The resource configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-13 17:34:52</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-13 17:34:52</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The resource group.</para>
        /// <para>If <c>Category</c> is <c>DataManagement</c>, the valid values are:</para>
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
        /// <para>If <c>Category</c> is <c>Engine</c>, the valid values are:</para>
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
        /// <para>If <c>Category</c> is <c>Monitor</c>, the valid values are:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D75C43DC-3D3A-5CC8-9AAC-8C77306C433B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-2s416t***</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

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

        /// <summary>
        /// <para>The resource URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket-test-123</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
