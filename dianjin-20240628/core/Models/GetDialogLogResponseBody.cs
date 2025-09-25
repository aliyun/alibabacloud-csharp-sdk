// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDialogLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDialogLogResponseBodyData Data { get; set; }
        public class GetDialogLogResponseBodyData : TeaModel {
            [NameInMap("analysisProcess")]
            [Validation(Required=false)]
            public string AnalysisProcess { get; set; }

            [NameInMap("conversationList")]
            [Validation(Required=false)]
            public string ConversationList { get; set; }

            [NameInMap("hitIntentionList")]
            [Validation(Required=false)]
            public List<GetDialogLogResponseBodyDataHitIntentionList> HitIntentionList { get; set; }
            public class GetDialogLogResponseBodyDataHitIntentionList : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

            }

            [NameInMap("intentionList")]
            [Validation(Required=false)]
            public List<GetDialogLogResponseBodyDataIntentionList> IntentionList { get; set; }
            public class GetDialogLogResponseBodyDataIntentionList : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("intentionName")]
                [Validation(Required=false)]
                public string IntentionName { get; set; }

                [NameInMap("intentionScript")]
                [Validation(Required=false)]
                public string IntentionScript { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1382</para>
            /// </summary>
            [NameInMap("modelCostTime")]
            [Validation(Required=false)]
            public long? ModelCostTime { get; set; }

            [NameInMap("recallList")]
            [Validation(Required=false)]
            public string RecallList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>051EEB18-049A-17FF-A5E0-14A5B127C798</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
