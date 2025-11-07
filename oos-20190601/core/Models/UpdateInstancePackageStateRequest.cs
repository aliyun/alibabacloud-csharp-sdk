// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateInstancePackageStateRequest : TeaModel {
        [NameInMap("ConfigurationInfo")]
        [Validation(Required=false)]
        public string ConfigurationInfo { get; set; }

        /// <summary>
        /// <para>The operation type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>uninstall</description></item>
        /// <item><description>install</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>install</para>
        /// </summary>
        [NameInMap("ConfigureAction")]
        [Validation(Required=false)]
        public string ConfigureAction { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Compute Service (ECS) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1jaxa2bs4bps7*****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The parameters for installing or uninstalling the extensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;username&quot;: &quot;xx&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

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
        /// <para>The name of the template.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
