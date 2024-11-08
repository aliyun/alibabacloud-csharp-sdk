// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListStateConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that was used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASO3cL82+b5iji7bfPNpMh8=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1306108F-610C-40FD-AAD5-DA13E8B00BE9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the desired-state configurations.</para>
        /// </summary>
        [NameInMap("StateConfigurations")]
        [Validation(Required=false)]
        public List<ListStateConfigurationsResponseBodyStateConfigurations> StateConfigurations { get; set; }
        public class ListStateConfigurationsResponseBodyStateConfigurations : TeaModel {
            /// <summary>
            /// <para>The configuration mode. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ApplyAndAutoCorrect</para>
            /// </summary>
            [NameInMap("ConfigureMode")]
            [Validation(Required=false)]
            public string ConfigureMode { get; set; }

            /// <summary>
            /// <para>The time when the desired-state configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-22T03:13:32Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collect inventory data</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;policy&quot;: {&quot;ACS:Network&quot;: {&quot;Collection&quot;: &quot;Enabled&quot;}, &quot;ACS:Application&quot;: {&quot;Collection&quot;: &quot;Enabled&quot;}}}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The schedule expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1 hour</para>
            /// </summary>
            [NameInMap("ScheduleExpression")]
            [Validation(Required=false)]
            public string ScheduleExpression { get; set; }

            /// <summary>
            /// <para>The schedule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rate</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>The ID of the desired-state configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-a538febe18fabcdef</para>
            /// </summary>
            [NameInMap("StateConfigurationId")]
            [Validation(Required=false)]
            public string StateConfigurationId { get; set; }

            /// <summary>
            /// <para>The tags added to the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Key&quot;: &quot;oos&quot;, &quot;Value&quot;: &quot;inventory&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The queried resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;ResourceType&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;Filters&quot;: [ { &quot;Type&quot;: &quot;All&quot;, &quot;RegionId&quot;: &quot;cn-hangzhou&quot;, &quot;Parameters&quot;: { &quot;RegionId&quot;: &quot;cn-hangzhou&quot;, &quot;Status&quot;: &quot;Running&quot; } } ] }</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public string Targets { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-ajshjalscfhjk2214</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-ECS-InventoryDataCollection</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The version of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The time when the configuration was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-22T03:13:32Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
