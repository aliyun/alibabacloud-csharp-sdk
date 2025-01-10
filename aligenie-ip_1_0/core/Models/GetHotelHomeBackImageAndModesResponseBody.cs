// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelHomeBackImageAndModesResponseBody : TeaModel {
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
        /// <para>394450FC-9035-1B7C-8829-BC88832473FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetHotelHomeBackImageAndModesResponseBodyResult Result { get; set; }
        public class GetHotelHomeBackImageAndModesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ailabs.alibabausercontent.com/platform/3d4fe6d66ec49d9789635f66627f0339/welcome_audios/976210a6532150f49c2677a8b7dbc105/l6fspbhn.jpg">https://ailabs.alibabausercontent.com/platform/3d4fe6d66ec49d9789635f66627f0339/welcome_audios/976210a6532150f49c2677a8b7dbc105/l6fspbhn.jpg</a></para>
            /// </summary>
            [NameInMap("BackgroundImage")]
            [Validation(Required=false)]
            public string BackgroundImage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>宣雍测试橙蜂酒店</para>
            /// </summary>
            [NameInMap("HotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            [NameInMap("ModeList")]
            [Validation(Required=false)]
            public List<GetHotelHomeBackImageAndModesResponseBodyResultModeList> ModeList { get; set; }
            public class GetHotelHomeBackImageAndModesResponseBodyResultModeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>浪漫模式</para>
                /// </summary>
                [NameInMap("CnName")]
                [Validation(Required=false)]
                public string CnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>romantic</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/changjingmoshi/langman.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/changjingmoshi/langman.png</a></para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

            }

        }

    }

}
