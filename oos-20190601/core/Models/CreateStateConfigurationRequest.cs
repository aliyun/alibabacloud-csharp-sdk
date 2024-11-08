// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateStateConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DASKJJLKADS-AHKLJHJSAKL-AJK</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration mode. Valid values: ApplyOnce: The configuration is applied only once. After a configuration is updated, the new configuration is applied. ApplyAndMonitor: The configuration is applied only once. After the configuration is applied, the system only checks whether the configuration is migrated in the future. ApplyAndAutoCorrect: The configuration is always applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApplyOnce</para>
        /// </summary>
        [NameInMap("ConfigureMode")]
        [Validation(Required=false)]
        public string ConfigureMode { get; set; }

        /// <summary>
        /// <para>The description of the desired-state configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The region ID.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;policy&quot;: {       &quot;ACS:Application&quot;: {         &quot;Collection&quot;: &quot;Enabled&quot;       },       &quot;ACS:Network&quot;: {         &quot;Collection&quot;: &quot;Enabled&quot;       }     }   }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The schedule expression. The interval between two schedules must be a minimum of 30 minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The ID of the resource group.</para>
        /// </summary>
        [NameInMap("ScheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// <para>The schedule type. Set the value to rate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rate</para>
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The tags to be added to the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Key&quot;: &quot;oos&quot;, &quot;Value&quot;: &quot;inventory&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The resources to be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;ResourceType&quot;: &quot;ALIYUN::ECS::Instance&quot;,     &quot;Filters&quot;: [       {         &quot;Type&quot;: &quot;All&quot;,         &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,         &quot;Parameters&quot;: {           &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,           &quot;Status&quot;: &quot;Running&quot;         }       }     ]   }</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string Targets { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must be 1 to 200 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS-ECS-InventoryDataCollection</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The version number of the template. If you do not specify this parameter, the latest version of the template is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
