// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateRumAppRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to restart the application the next day. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRestart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// <para>The collection configurations of the mobile SDK. You can enable or disable collection configurations based on the app version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;moduleConfig\&quot;:{\&quot;enable\&quot;:true,\&quot;defaultConfig\&quot;:{\&quot;network\&quot;:{\&quot;enable\&quot;:true},\&quot;h5\&quot;:{\&quot;enable\&quot;:true},\&quot;routechange\&quot;:{\&quot;enable\&quot;:true},\&quot;crash\&quot;:{\&quot;enable\&quot;:true},\&quot;view\&quot;:{\&quot;enable\&quot;:true},\&quot;coollaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;hotlaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;action\&quot;:{\&quot;enable\&quot;:true},\&quot;lagstuck\&quot;:{\&quot;enable\&quot;:true},\&quot;lagfps\&quot;:{\&quot;enable\&quot;:true},\&quot;statechange\&quot;:{\&quot;enable\&quot;:true},\&quot;anr\&quot;:{\&quot;enable\&quot;:true},\&quot;customlog\&quot;:{\&quot;enable\&quot;:true},\&quot;customevent\&quot;:{\&quot;enable\&quot;:true},\&quot;custommetric\&quot;:{\&quot;enable\&quot;:true}},\&quot;versionConfigs\&quot;:{\&quot;1.1.0\&quot;:{\&quot;useCustom\&quot;:true,\&quot;customConfig\&quot;:{\&quot;network\&quot;:{\&quot;enable\&quot;:true},\&quot;h5\&quot;:{\&quot;enable\&quot;:true},\&quot;routechange\&quot;:{\&quot;enable\&quot;:true},\&quot;crash\&quot;:{\&quot;enable\&quot;:true},\&quot;view\&quot;:{\&quot;enable\&quot;:true},\&quot;coollaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;hotlaunch\&quot;:{\&quot;enable\&quot;:true},\&quot;action\&quot;:{\&quot;enable\&quot;:true},\&quot;lagstuck\&quot;:{\&quot;enable\&quot;:false},\&quot;lagfps\&quot;:{\&quot;enable\&quot;:false},\&quot;statechange\&quot;:{\&quot;enable\&quot;:true},\&quot;anr\&quot;:{\&quot;enable\&quot;:true},\&quot;customlog\&quot;:{\&quot;enable\&quot;:true},\&quot;customevent\&quot;:{\&quot;enable\&quot;:true},\&quot;custommetric\&quot;:{\&quot;enable\&quot;:true}}},\&quot;1.2.0\&quot;:{\&quot;useCustom\&quot;:false,\&quot;customConfig\&quot;:{}}}}}</para>
        /// </summary>
        [NameInMap("BackendServiceTraceRegion")]
        [Validation(Required=false)]
        public string BackendServiceTraceRegion { get; set; }

        /// <summary>
        /// <para>The collection configurations of the mobile SDK. You can enable or disable collection configurations based on the app version.</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether you want to subscribe to the application. Valid values: true and false.</para>
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
        /// <para>Android Test</para>
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
        /// <para>Backend application deployment area (used in end-to-end link scenarios).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>Specifies whether to restart the application. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>The service domain name of the application. You can create, modify, and delete service domain name configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Op\&quot;:\&quot;Update\&quot;,\&quot;Domain\&quot;:\&quot;example.com\&quot;,\&quot;Config\&quot;:{\&quot;Description\&quot;:\&quot;message\&quot;,\&quot;Tracing\&quot;:\&quot;true\&quot;,\&quot;PropagatorTypes\&quot;:[\&quot;sw8\&quot;]}}</para>
        /// </summary>
        [NameInMap("ServiceDomainOperationJson")]
        [Validation(Required=false)]
        public string ServiceDomainOperationJson { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop the application. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

    }

}
