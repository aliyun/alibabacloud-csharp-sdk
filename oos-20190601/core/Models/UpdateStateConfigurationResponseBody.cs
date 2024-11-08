// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateStateConfigurationResponseBody : TeaModel {
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
        /// <para>The details of the configuration.</para>
        /// </summary>
        [NameInMap("StateConfiguration")]
        [Validation(Required=false)]
        public List<UpdateStateConfigurationResponseBodyStateConfiguration> StateConfiguration { get; set; }
        public class UpdateStateConfigurationResponseBodyStateConfiguration : TeaModel {
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
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-22T03:13:32Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the desired-state configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>collect inventory data</para>
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
            /// <para>The CRON expression.</para>
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
            /// <para>StateConfigurationId</para>
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
            /// <para>t-1234asadf</para>
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
            /// <para>The name of the template version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The time when the configuration was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-22T03:13:32Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
