// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListDialogueTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDialogueTemplateResponseBodyResult> Result { get; set; }
        public class ListDialogueTemplateResponseBodyResult : TeaModel {
            [NameInMap("TemplateDetail")]
            [Validation(Required=false)]
            public ListDialogueTemplateResponseBodyResultTemplateDetail TemplateDetail { get; set; }
            public class ListDialogueTemplateResponseBodyResultTemplateDetail : TeaModel {
                [NameInMap("FirstDialogueTemplate")]
                [Validation(Required=false)]
                public ListDialogueTemplateResponseBodyResultTemplateDetailFirstDialogueTemplate FirstDialogueTemplate { get; set; }
                public class ListDialogueTemplateResponseBodyResultTemplateDetailFirstDialogueTemplate : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>${goodsName}${price}元，请问需要服务员送来吗？</para>
                    /// </summary>
                    [NameInMap("NonzeroPriceYesAnswer")]
                    [Validation(Required=false)]
                    public string NonzeroPriceYesAnswer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>对不起，暂时不提供此物品。</para>
                    /// </summary>
                    [NameInMap("ZeroPriceNoAnswer")]
                    [Validation(Required=false)]
                    public string ZeroPriceNoAnswer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>好的，服务员会尽快送来。</para>
                    /// </summary>
                    [NameInMap("ZeroPriceYesAnswer")]
                    [Validation(Required=false)]
                    public string ZeroPriceYesAnswer { get; set; }

                }

                [NameInMap("SecondDialogueTemplate")]
                [Validation(Required=false)]
                public ListDialogueTemplateResponseBodyResultTemplateDetailSecondDialogueTemplate SecondDialogueTemplate { get; set; }
                public class ListDialogueTemplateResponseBodyResultTemplateDetailSecondDialogueTemplate : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>好的，已取消。</para>
                    /// </summary>
                    [NameInMap("NonzeroPriceNoAnswer")]
                    [Validation(Required=false)]
                    public string NonzeroPriceNoAnswer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>好的，服务员会尽快送来${goodsName}</para>
                    /// </summary>
                    [NameInMap("NonzeroPriceYesAnswer")]
                    [Validation(Required=false)]
                    public string NonzeroPriceYesAnswer { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>物品多轮模板</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GOODS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
