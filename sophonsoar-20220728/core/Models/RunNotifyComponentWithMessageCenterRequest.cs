// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunNotifyComponentWithMessageCenterRequest : TeaModel {
        /// <summary>
        /// <para>The action name of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notifyByMessageCenter</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>The user ID receiving the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>146789xxxx733152</para>
        /// </summary>
        [NameInMap("Aliuid")]
        [Validation(Required=false)]
        public string Aliuid { get; set; }

        /// <summary>
        /// <para>Resource instance ID. This parameter is currently deprecated and no longer in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>Collection of channel types. If not provided, all channels will be used by default, and it is not required to provide this parameter by default.</para>
        /// </summary>
        [NameInMap("ChannelTypeList")]
        [Validation(Required=false)]
        public List<string> ChannelTypeList { get; set; }

        /// <summary>
        /// <para>The component name of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotifyMessage</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>Cloud Pigeon\&quot;s message event ID. Values:</para>
        /// <list type="bullet">
        /// <item><description>yundun_soar_incident_generate: Incident generation.</description></item>
        /// <item><description>yundun_soar_alert_generate: Alert generation.</description></item>
        /// <item><description>yundun_soar_incident_update: Incident update.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yundun_soar_incident_generate</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The language type for requesting and receiving messages. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The node name of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notify_message</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>Template parameters for the message event.</para>
        /// <list type="bullet">
        /// <item><description>For incident generation: aliyunUID, incidentName, incidentID, startTime</description></item>
        /// <item><description>For alert generation: aliyunUID, alertName, alertID, startTime</description></item>
        /// <item><description>For incident update: aliyunUID, incidentName, incidentID, startTime, endTime, status, level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;startTime&quot;:&quot;test222&quot;,&quot;incidentName&quot;:&quot;test123&quot;,&quot;incidentID&quot;:&quot;teset123&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> interface.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c88b5e-97ca-435d-8c20-xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The user ID when an administrator switches to another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1467894xxx733152</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>View type. Values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): Current Alibaba Cloud account view.</description></item>
        /// <item><description>1: View for all accounts under the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
