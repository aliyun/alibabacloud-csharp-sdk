// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentionsRequest : TeaModel {
        /// <summary>
        /// <para><notice>This parameter is required. Select a value based on the scenario.</notice></para>
        /// <para>The data source of the annotation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: outbound call</description></item>
        /// <item><description>2: navigation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public long? AnnotationMissionDataSourceType { get; set; }

        /// <summary>
        /// <para>The ID of the bot. You can obtain the ID from the ChatbotId parameter in the response of the DescribeScript operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-n7QmzrUnNe</para>
        /// </summary>
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: private cloud</description></item>
        /// <item><description>2: public cloud</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public long? Environment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e5035654-1745-484a-8c5b-165f7c7bcd79</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10717802</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The name of the intent. You can use keywords to perform a fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Know</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
