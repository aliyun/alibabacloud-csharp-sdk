// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunNotifyComponentWithMessageCenterRequest : TeaModel {
        /// <summary>
        /// <para>The name of the playbook action.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notifyByMessageCenter</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>The ID of the user who receives the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>146789xxxx733152</para>
        /// </summary>
        [NameInMap("Aliuid")]
        [Validation(Required=false)]
        public string Aliuid { get; set; }

        /// <summary>
        /// <para>The ID of the asset. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>A collection of channel types. If you do not specify this parameter, messages are sent through all channels by default.</para>
        /// </summary>
        [NameInMap("ChannelTypeList")]
        [Validation(Required=false)]
        public List<string> ChannelTypeList { get; set; }

        /// <summary>
        /// <para>The name of the playbook component.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotifyMessage</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The ID of the message event in Message Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>yundun_soar_incident_generate: An event is generated.</para>
        /// </description></item>
        /// <item><description><para>yundun_soar_alert_generate: An alert is generated.</para>
        /// </description></item>
        /// <item><description><para>yundun_soar_incident_update: An event is updated.</para>
        /// </description></item>
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
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the playbook node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notify_message</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The template parameters for the message event.</para>
        /// <list type="bullet">
        /// <item><description><para>Event generation: aliyunUID, incidentName, incidentID, startTime</para>
        /// </description></item>
        /// <item><description><para>Alert generation: aliyunUID, alertName, alertID, startTime</para>
        /// </description></item>
        /// <item><description><para>Event update: aliyunUID, incidentName, incidentID, startTime, endTime, status, level</para>
        /// </description></item>
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
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain the value of this parameter.</para>
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
        /// <para>The user ID of the member. This parameter is used when an administrator calls the operation on behalf of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1467894xxx733152</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default): The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that belong to the enterprise.</para>
        /// </description></item>
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
