// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelSceneItemDetailResponseBody : TeaModel {
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
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetHotelSceneItemDetailResponseBodyResult Result { get; set; }
        public class GetHotelSceneItemDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>客用品类</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("DialogueList")]
            [Validation(Required=false)]
            public List<GetHotelSceneItemDetailResponseBodyResultDialogueList> DialogueList { get; set; }
            public class GetHotelSceneItemDetailResponseBodyResultDialogueList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1666164774</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>336</para>
                /// </summary>
                [NameInMap("DialogueId")]
                [Validation(Required=false)]
                public string DialogueId { get; set; }

                [NameInMap("NoAnswer")]
                [Validation(Required=false)]
                public string NoAnswer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("NoAnswerTemplate")]
                [Validation(Required=false)]
                public string NoAnswerTemplate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public int? Process { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10336</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1666164774</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("YesAnswer")]
                [Validation(Required=false)]
                public string YesAnswer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("YesAnswerTemplate")]
                [Validation(Required=false)]
                public string YesAnswerTemplate { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/zhijin.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/zhijin.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10336</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>擦鞋布</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>170</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已添加</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GOODS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1666168828</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
