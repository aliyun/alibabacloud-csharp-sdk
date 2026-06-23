// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDialogLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The processing time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDialogLogResponseBodyData Data { get; set; }
        public class GetDialogLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The analysis process. This field has a value if the analysis process is enabled during the real-time conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户回答的内容与提供的意图列表描述均不匹配，没有表达出对账单、还款、天气或其他服务的具体需求或问题。</para>
            /// </summary>
            [NameInMap("analysisProcess")]
            [Validation(Required=false)]
            public string AnalysisProcess { get; set; }

            /// <summary>
            /// <para>The <c>conversationList</c> field records the conversation content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>##客服##:您好，请问是张三先生是吧？\n ##客户##:人工客服\n ##客服##:您好，我是2804，很高兴为您服务！\n ##客服##:您好，请问有什么可以帮到您？\n ##客户##:好的 谢谢\n</para>
            /// </summary>
            [NameInMap("conversationList")]
            [Validation(Required=false)]
            public string ConversationList { get; set; }

            /// <summary>
            /// <para>The list of hit intents.</para>
            /// </summary>
            [NameInMap("hitIntentionList")]
            [Validation(Required=false)]
            public List<GetDialogLogResponseBodyDataHitIntentionList> HitIntentionList { get; set; }
            public class GetDialogLogResponseBodyDataHitIntentionList : TeaModel {
                /// <summary>
                /// <para>A description of the customer\&quot;s intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户希望与真人接触，不想和AI客服继续对话。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户要求转人工</para>
                /// </summary>
                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                /// <summary>
                /// <para>The scripted reply based on the customer\&quot;s intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>很抱歉，我这里无法直接为您转接，您可以拨打我司客服热线进行咨询。</para>
                /// </summary>
                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

            }

            /// <summary>
            /// <para>The intent list.</para>
            /// </summary>
            [NameInMap("intentionList")]
            [Validation(Required=false)]
            public List<GetDialogLogResponseBodyDataIntentionList> IntentionList { get; set; }
            public class GetDialogLogResponseBodyDataIntentionList : TeaModel {
                /// <summary>
                /// <para>The <c>description</c> field provides a detailed description of the user\&quot;s intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户明确表示投诉/退订/不要打电话/骂人等拒绝营销</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户明确表示拒绝营销</para>
                /// </summary>
                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                /// <summary>
                /// <para>The <c>intentionScript</c> field contains the service agent\&quot;s reply script for the user\&quot;s intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>非常抱歉，给您带来了不好的体验。如您无需再接受我们的官方来电，请回复“我要退订”四个字！</para>
                /// </summary>
                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

            }

            /// <summary>
            /// <para>The model processing time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1382</para>
            /// </summary>
            [NameInMap("modelCostTime")]
            [Validation(Required=false)]
            public long? ModelCostTime { get; set; }

            /// <summary>
            /// <para>The recall list.</para>
            /// 
            /// <b>Example:</b>
            /// <h2>Example:\n- 对话内容为：\&quot;##客服##:您好，请问有什么可以帮到您？\n ##客户##:暂时没有了。谢谢。\&quot;时，用户意图为：\&quot;客户想要挂断电话\&quot;\n- 对话内容为：\&quot;##客服##:您好，请问有什么可以帮到您？\n ##客户##:哎你好。\&quot;时，用户意图为：\&quot;客户询问来电目的\&quot;\n- 对话内容为：\&quot;##客服##:您好，请问有什么可以帮到您？\n ##客户##:我现在财务状况很好，谢谢关心。\&quot;时，用户意图为：\&quot;客户拒绝贷款\&quot;\n- 对话内容为：\&quot;##客服##:您好，请问有什么可以帮到您？\n ##客户##:不用了，谢谢，不要再打电话了，谢谢。\&quot;时，用户意图为：\&quot;投诉/退订/不要打电话/骂人\&quot;\n- 对话内容为：\&quot;##客服##:您好，请问有什么可以帮到您？\n ##客户##:你好。\&quot;时，用户意图为：\&quot;客户询问来电目的\&quot;</h2>
            /// </summary>
            [NameInMap("recallList")]
            [Validation(Required=false)]
            public string RecallList { get; set; }

        }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>051EEB18-049A-17FF-A5E0-14A5B127C798</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
