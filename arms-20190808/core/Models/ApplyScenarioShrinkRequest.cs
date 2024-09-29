// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ApplyScenarioShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b590lhguqs@28f515462f******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The configuration of the business monitoring job. The value is a JSON string. For more information about this parameter, see the following additional information about the <b>Config</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rpcType&quot;:&quot;0&quot;,&quot;nameMatchType&quot;:&quot;EQUALS&quot;,&quot;service&quot;:&quot;/api/pop/test&quot;,&quot;operator&quot;:&quot;and&quot;,&quot;filterItems&quot;:[{&quot;type&quot;:&quot;HttpHeaders&quot;,&quot;key&quot;:&quot;uid&quot;,&quot;opt&quot;:&quot;==&quot;,&quot;value&quot;:&quot;123456789&quot;}],&quot;group&quot;:{&quot;type&quot;:&quot;HttpRequestParameters&quot;,&quot;key&quot;:&quot;name&quot;}}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

        /// <summary>
        /// <para>The name of the business monitoring job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScenarioName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjaikou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scenario where you want to use the business monitoring job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>USER-DEFINED</c>: user-defined. This is the default value.</description></item>
        /// <item><description><c>EDAS-ROLLOUT</c>: application release in Enterprise Distributed Application Service (EDAS)</description></item>
        /// <item><description><c>OAM-ROLLOUT</c>: application release based on Open Application Model (OAM)</description></item>
        /// <item><description><c>MSC-CANARY</c>: canary release based on Microservice Engine (MSE)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER-DEFINED</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The code of the business monitoring job. This parameter is not required when you create a business monitoring job. However, this parameter is required when you update a business monitoring job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9f8****</para>
        /// </summary>
        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        /// <summary>
        /// <para>Specifies whether to record business parameters to the trace marked with the coloring sign.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c>: This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SnDump")]
        [Validation(Required=false)]
        public bool? SnDump { get; set; }

        /// <summary>
        /// <para>Specifies whether traffic in the trace marked with the coloring sign is all collected.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c>: This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SnForce")]
        [Validation(Required=false)]
        public bool? SnForce { get; set; }

        /// <summary>
        /// <para>Specifies whether to count traffic based on the coloring sign.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c>: This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SnStat")]
        [Validation(Required=false)]
        public bool? SnStat { get; set; }

        /// <summary>
        /// <para>Specifies whether the coloring sign is transparently passed down to downstream application nodes in the trace.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c>: This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SnTransfer")]
        [Validation(Required=false)]
        public bool? SnTransfer { get; set; }

        /// <summary>
        /// <para>Specifies whether the operation is an update operation.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: update</description></item>
        /// <item><description><c>false</c>: insert</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public bool? UpdateOption { get; set; }

    }

}
