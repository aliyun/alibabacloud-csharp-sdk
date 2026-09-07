// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateRumAppRequest : TeaModel {
        /// <summary>
        /// <para>The legacy application configuration in JSON format. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;apiRequestOfH5&quot;:300,&quot;apiRequestOfOriginal&quot;:500,&quot;coldStart&quot;:5000,&quot;hotStart&quot;:3000,&quot;staticResourceLoad&quot;:300,&quot;stutter&quot;:1000,&quot;viewLoadOfH5&quot;:1000,&quot;viewLoadOfOriginal&quot;:2000}</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the application the next day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Restart.</description></item>
        /// <item><description>false: Do not restart.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRestart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// <para>The region where the backend application is deployed. This parameter is used in end-to-end tracing scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BackendServiceTraceRegion")]
        [Validation(Required=false)]
        public string BackendServiceTraceRegion { get; set; }

        /// <summary>
        /// <para>The mobile SDK collection configuration. You can enable or disable collection items by app version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;moduleConfig\&quot;:{\&quot;enable\&quot;:true,\&quot;defaultConfig\&quot;:{\&quot;network\&quot;:{\&quot;enable\&quot;:true},\&quot;h5\&quot;:{\&quot;enable\&quot;:true},\&quot;routechange\&quot;:{\&quot;enable\&quot;:true},\&quot;crash\&quot;:{\&quot;enable\&quot;:true},\&quot;view\&quot;:{\&quot;enable\&quot;:true},\&quot;coollaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;hotlaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;action\&quot;:{\&quot;enable\&quot;:true},\&quot;lagstuck\&quot;:{\&quot;enable\&quot;:true},\&quot;lagfps\&quot;:{\&quot;enable\&quot;:true},\&quot;statechange\&quot;:{\&quot;enable\&quot;:true},\&quot;anr\&quot;:{\&quot;enable\&quot;:true},\&quot;customlog\&quot;:{\&quot;enable\&quot;:true},\&quot;customevent\&quot;:{\&quot;enable\&quot;:true},\&quot;custommetric\&quot;:{\&quot;enable\&quot;:true}},\&quot;versionConfigs\&quot;:{\&quot;1.1.0\&quot;:{\&quot;useCustom\&quot;:true,\&quot;customConfig\&quot;:{\&quot;network\&quot;:{\&quot;enable\&quot;:true},\&quot;h5\&quot;:{\&quot;enable\&quot;:true},\&quot;routechange\&quot;:{\&quot;enable\&quot;:true},\&quot;crash\&quot;:{\&quot;enable\&quot;:true},\&quot;view\&quot;:{\&quot;enable\&quot;:true},\&quot;coollaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;hotlaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;action\&quot;:{\&quot;enable\&quot;:true},\&quot;lagstuck\&quot;:{\&quot;enable\&quot;:false},\&quot;lagfps\&quot;:{\&quot;enable\&quot;:false},\&quot;statechange\&quot;:{\&quot;enable\&quot;:true},\&quot;anr\&quot;:{\&quot;enable\&quot;:true},\&quot;customlog\&quot;:{\&quot;enable\&quot;:true},\&quot;customevent\&quot;:{\&quot;enable\&quot;:true},\&quot;custommetric\&quot;:{\&quot;enable\&quot;:true}}},\&quot;1.2.0\&quot;:{\&quot;useCustom\&quot;:false,\&quot;customConfig\&quot;:{}}}}}</para>
        /// </summary>
        [NameInMap("BonreeSDKConfigJson")]
        [Validation(Required=false)]
        public string BonreeSDKConfigJson { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the application to favorites. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Add to favorites.</description></item>
        /// <item><description>false: Do not add to favorites.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSubscribe")]
        [Validation(Required=false)]
        public bool? IsSubscribe { get; set; }

        /// <summary>
        /// <para>The alias of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>应用别名。</para>
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5xxxxs@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region where the application is actually connected. This parameter is used only in the China (Shanghai) Finance Cloud scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-finance-1</para>
        /// </summary>
        [NameInMap("RealRegionId")]
        [Validation(Required=false)]
        public string RealRegionId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Restart.</description></item>
        /// <item><description>false: Do not restart.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>The service domain name settings for the application. You can create, update, or delete service domain name configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Op\&quot;:\&quot;Update\&quot;,\&quot;Domain\&quot;:\&quot;example.com\&quot;,\&quot;Config\&quot;:{\&quot;Description\&quot;:\&quot;这是描述bbb\&quot;,\&quot;Tracing\&quot;:\&quot;true\&quot;,\&quot;PropagatorTypes\&quot;:[\&quot;sw8\&quot;]}}</para>
        /// </summary>
        [NameInMap("ServiceDomainOperationJson")]
        [Validation(Required=false)]
        public string ServiceDomainOperationJson { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Stop.</description></item>
        /// <item><description>false: Do not stop.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

        [NameInMap("WebSDKConfigJson")]
        [Validation(Required=false)]
        public string WebSDKConfigJson { get; set; }

    }

}
