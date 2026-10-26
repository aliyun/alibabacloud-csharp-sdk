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
        /// <item><description>DataManagement</description></item>
        /// <item><description>Engine</description></item>
        /// <item><description>Monitor</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataManagement</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The configuration information of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The creation time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-13 17:34:52</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The update time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-13 17:34:52</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The resource group.</para>
        /// <para>If the resource category is DataManagement, valid values are:</para>
        /// <list type="bullet">
        /// <item><description>storage</description></item>
        /// <item><description>modelpipeline</description></item>
        /// <item><description>datastorage</description></item>
        /// <item><description>modeltrain</description></item>
        /// </list>
        /// <para>If the resource category is Engine, valid values are:</para>
        /// <list type="bullet">
        /// <item><description>feature</description></item>
        /// <item><description>predict</description></item>
        /// <item><description>recall</description></item>
        /// <item><description>recengine</description></item>
        /// </list>
        /// <para>If the resource category is Monitor, valid values are:</para>
        /// <list type="bullet">
        /// <item><description>logs</description></item>
        /// <item><description>logsback</description></item>
        /// <item><description>coldstart</description></item>
        /// <item><description>deploy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>storage</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D75C43DC-3D3A-5CC8-9AAC-8C77306C433B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
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
        /// <item><description>Hologres</description></item>
        /// <item><description>EAS</description></item>
        /// <item><description>BE</description></item>
        /// <item><description>Rec</description></item>
        /// <item><description>Platform</description></item>
        /// <item><description>SLS</description></item>
        /// <item><description>DataHub</description></item>
        /// <item><description>Kafka</description></item>
        /// <item><description>Flinkvvp</description></item>
        /// <item><description>ACR</description></item>
        /// <item><description>OSS</description></item>
        /// <item><description>DataWorks</description></item>
        /// <item><description>PAI</description></item>
        /// <item><description>MaxCompute</description></item>
        /// <item><description>GraphCompute</description></item>
        /// <item><description>Redis</description></item>
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
