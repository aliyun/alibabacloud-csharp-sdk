// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSliderCaptchaPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The predefined configurations for the custom slider page.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public GetSliderCaptchaPageResponseBodyConfigs Configs { get; set; }
        public class GetSliderCaptchaPageResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The predefined English style.</para>
            /// </summary>
            [NameInMap("En")]
            [Validation(Required=false)]
            public GetSliderCaptchaPageResponseBodyConfigsEn En { get; set; }
            public class GetSliderCaptchaPageResponseBodyConfigsEn : TeaModel {
                /// <summary>
                /// <para>Specifies whether to display the footer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowFooter")]
                [Validation(Required=false)]
                public bool? ShowFooter { get; set; }

                /// <summary>
                /// <para>Specifies whether to display the request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowRequestId")]
                [Validation(Required=false)]
                public bool? ShowRequestId { get; set; }

                /// <summary>
                /// <para>The slider color.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFFFFF</para>
                /// </summary>
                [NameInMap("SliderColor")]
                [Validation(Required=false)]
                public string SliderColor { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The predefined Chinese style.</para>
            /// </summary>
            [NameInMap("Zh")]
            [Validation(Required=false)]
            public GetSliderCaptchaPageResponseBodyConfigsZh Zh { get; set; }
            public class GetSliderCaptchaPageResponseBodyConfigsZh : TeaModel {
                /// <summary>
                /// <para>Specifies whether to display the footer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ShowFooter")]
                [Validation(Required=false)]
                public bool? ShowFooter { get; set; }

                /// <summary>
                /// <para>Specifies whether to display the request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ShowRequestId")]
                [Validation(Required=false)]
                public bool? ShowRequestId { get; set; }

                /// <summary>
                /// <para>The slider color.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFFFFF</para>
                /// </summary>
                [NameInMap("SliderColor")]
                [Validation(Required=false)]
                public string SliderColor { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom slider configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;language&quot;:&quot;ko&quot;,&quot;description&quot;:&quot;더 나은 경험을 위해 웹 페이지에 접속하기 전에 슬라이드하여 인증을 완료해 주세요.&quot;,&quot;captcha_color&quot;:&quot;#28870d&quot;,&quot;show_trace_id&quot;:true,&quot;show_footer&quot;:true,&quot;mandatory_lang&quot;:false}]</para>
        /// </summary>
        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        /// <summary>
        /// <para>The forced language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("ForceLanguage")]
        [Validation(Required=false)]
        public string ForceLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the custom slider page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the custom slider page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of bound site IDs.</para>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public List<long?> SiteIds { get; set; }

    }

}
