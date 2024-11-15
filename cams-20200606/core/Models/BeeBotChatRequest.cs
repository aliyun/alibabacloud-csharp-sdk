// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotChatRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the answer is in plain text or rich text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChatBotInstanceId")]
        [Validation(Required=false)]
        public string ChatBotInstanceId { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The source of the answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intent</para>
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// <para>The source of the answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ksiekdki39ksks93939</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The hit statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        /// <summary>
        /// <para>The information about the slot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861500000000</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <para>Beijing</para>
        /// 
        /// <b>Example:</b>
        /// <para>nick</para>
        /// </summary>
        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// <para>The title of the related knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The title of the hit question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>659216218162179</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        /// <summary>
        /// <para>The node name. When AnswerSource is set to BotFramework, a value is returned for this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;skills\&quot;:\&quot;chat_search\&quot;,\&quot;accessToken\&quot;:\&quot;73f4d5c8e8c334d9b538890bca68ac9a\&quot;,\&quot;senderStaffId\&quot;:\&quot;1697204021326\&quot;,\&quot;senderCorpId\&quot;:\&quot;dingee291fb2828058b9\&quot;}</para>
        /// </summary>
        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> VendorParam { get; set; }

    }

}
