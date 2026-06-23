// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecognizeIntentionRequest : TeaModel {
        /// <summary>
        /// <para>Enable analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("analysis")]
        [Validation(Required=false)]
        public bool? Analysis { get; set; }

        /// <summary>
        /// <para>Business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Conversation text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>##客服##：您好，请问是朱杰先生吗？这里是诚信财务的周莉。我们发现您有一项款项昨天是账单日，但您还没还款，这很可能是一个小小的疏忽。来电是提醒您尽快完成还款，避免影响您的信用记录。\n ##客户##：今天天气怎么样呢？</para>
        /// </summary>
        [NameInMap("conversation")]
        [Validation(Required=false)]
        public string Conversation { get; set; }

        /// <summary>
        /// <para>Global intent list. Required when opType is hierarchical.</para>
        /// </summary>
        [NameInMap("globalIntentionList")]
        [Validation(Required=false)]
        public List<RecognizeIntentionRequestGlobalIntentionList> GlobalIntentionList { get; set; }
        public class RecognizeIntentionRequestGlobalIntentionList : TeaModel {
            /// <summary>
            /// <para>Intent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>正常付款3</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Intent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>正常付款3</para>
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            /// <summary>
            /// <para>Intent code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1810566978021232640</para>
            /// </summary>
            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

            /// <summary>
            /// <para>Intent script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>好的，那先不打扰您了，祝您生活愉快！再见！</para>
            /// </summary>
            [NameInMap("intentionScript")]
            [Validation(Required=false)]
            public string IntentionScript { get; set; }

        }

        /// <summary>
        /// <para>Hierarchical intent list. Required when opType is hierarchical.</para>
        /// </summary>
        [NameInMap("hierarchicalIntentionList")]
        [Validation(Required=false)]
        public List<RecognizeIntentionRequestHierarchicalIntentionList> HierarchicalIntentionList { get; set; }
        public class RecognizeIntentionRequestHierarchicalIntentionList : TeaModel {
            /// <summary>
            /// <para>Intent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>询问股票价格</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Intent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>询问股票价格</para>
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            /// <summary>
            /// <para>Intent code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1810929291010150400</para>
            /// </summary>
            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

            /// <summary>
            /// <para>Intent script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>好的，那先不打扰您了，祝您生活愉快！再见！</para>
            /// </summary>
            [NameInMap("intentionScript")]
            [Validation(Required=false)]
            public string IntentionScript { get; set; }

        }

        /// <summary>
        /// <para>Intent library: Local intent library code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>collection</para>
        /// </summary>
        [NameInMap("intentionDomainCode")]
        [Validation(Required=false)]
        public string IntentionDomainCode { get; set; }

        /// <summary>
        /// <para>Intent list. Required when bizType is not attitude.</para>
        /// </summary>
        [NameInMap("intentionList")]
        [Validation(Required=false)]
        public List<RecognizeIntentionRequestIntentionList> IntentionList { get; set; }
        public class RecognizeIntentionRequestIntentionList : TeaModel {
            /// <summary>
            /// <para>Intent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户表示忘记还款</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Intent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户表示忘记还款</para>
            /// </summary>
            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            /// <summary>
            /// <para>Intent code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1808766224000262144</para>
            /// </summary>
            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

            /// <summary>
            /// <para>Intent script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>好的，那先不打扰您了，祝您生活愉快！再见！</para>
            /// </summary>
            [NameInMap("intentionScript")]
            [Validation(Required=false)]
            public string IntentionScript { get; set; }

        }

        /// <summary>
        /// <para>Operation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("opType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        /// <summary>
        /// <para>Recommend intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recommend")]
        [Validation(Required=false)]
        public bool? Recommend { get; set; }

    }

}
