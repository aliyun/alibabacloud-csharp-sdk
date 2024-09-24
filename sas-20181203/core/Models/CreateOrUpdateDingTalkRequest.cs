// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOrUpdateDingTalkRequest : TeaModel {
        /// <summary>
        /// <para>The alerts for which you want the chatbot to send notifications. The value is a JSON array that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the types of alerts. The valid values are listed in the &quot;Additional description of parameters&quot; section in this topic.</para>
        /// </description></item>
        /// <item><description><para><b>configItemList</b>: the list of check items. The value is a JSON array that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>key</b>: the key of the check item.</description></item>
        /// <item><description><b>valueList</b>: the values of the check item. The value of valueList is a JSON array.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the value of this parameter, see the &quot;Addition description of parameters&quot; section in this topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;sas_analysis_online-sas-operation-log-sas-event-suspicious&quot;,&quot;configItemList&quot;:[{&quot;key&quot;:&quot;item_level&quot;,&quot;valueList&quot;:[&quot;all&quot;]},{&quot;key&quot;:&quot;event_type&quot;,&quot;valueList&quot;:[&quot;all&quot;]}]}]</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        /// <summary>
        /// <para>The language of the notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("DingTalkLang")]
        [Validation(Required=false)]
        public string DingTalkLang { get; set; }

        /// <summary>
        /// <para>The IDs of asset groups for which you want the chatbot to send notifications. The value is a JSON array.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupStruct~~">DescribeGroupStruct</a> operation to query the IDs of asset groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10417151&quot;]</para>
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        /// <summary>
        /// <para>The ID of the chatbot.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://www.alibabacloud.com/help/en/security-center/developer-reference/api-sas-2018-12-03-describedingtalk/?spm=a2c63.p38356.0.0.681e4360Qd1eb1">DescribeDingTalk</a> operation to query the IDs of chatbots.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1589</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The time interval at which the chatbot sends notifications.</para>
        /// <remarks>
        /// <para>The value <b>0</b> indicates unlimited.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public long? IntervalTime { get; set; }

        /// <summary>
        /// <para>The name of the chatbot.</para>
        /// <remarks>
        /// <para>The name of a chatbot must be 2 to 64 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNotify</para>
        /// </summary>
        [NameInMap("RuleActionName")]
        [Validation(Required=false)]
        public string RuleActionName { get; set; }

        /// <summary>
        /// <para>The webhook URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=XXX">https://oapi.dingtalk.com/robot/send?access_token=XXX</a></para>
        /// </summary>
        [NameInMap("SendUrl")]
        [Validation(Required=false)]
        public string SendUrl { get; set; }

    }

}
