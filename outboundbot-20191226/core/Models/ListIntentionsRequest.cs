// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentionsRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required. Select based on the scenario.</para>
        /// <para>Annotation data source.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Outbound Call</para>
        /// </description></item>
        /// <item><description><para>2: Navigation</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public long? AnnotationMissionDataSourceType { get; set; }

        /// <summary>
        /// <para>Bot ID</para>
        /// <remarks>
        /// <para>Get this from the DescribeScript API. The corresponding parameter is ChatbotId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-n7QmzrUnNe</para>
        /// </summary>
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <para>Environment</para>
        /// <list type="bullet">
        /// <item><description><para>1: Private Cloud</para>
        /// </description></item>
        /// <item><description><para>2: Public Cloud</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public long? Environment { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>e5035654-1745-484a-8c5b-165f7c7bcd79</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Intent ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10717802</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// <para>Page Number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>Number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Scenario ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>Intent Name</para>
        /// <remarks>
        /// <para>Use this for fuzzy queries based on keywords.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>知道</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
