// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSliderCaptchaPageRequest : TeaModel {
        /// <summary>
        /// <para>The predefined configurations for the custom slider page.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public CreateSliderCaptchaPageRequestConfigs Configs { get; set; }
        public class CreateSliderCaptchaPageRequestConfigs : TeaModel {
            /// <summary>
            /// <para>The predefined English style.</para>
            /// </summary>
            [NameInMap("En")]
            [Validation(Required=false)]
            public CreateSliderCaptchaPageRequestConfigsEn En { get; set; }
            public class CreateSliderCaptchaPageRequestConfigsEn : TeaModel {
                /// <summary>
                /// <para>Specifies whether to show the footer.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowFooter")]
                [Validation(Required=false)]
                public bool? ShowFooter { get; set; }

                /// <summary>
                /// <para>Specifies whether to show the request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowRequestId")]
                [Validation(Required=false)]
                public bool? ShowRequestId { get; set; }

                /// <summary>
                /// <para>The color of the slider.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFFFFF</para>
                /// </summary>
                [NameInMap("SliderColor")]
                [Validation(Required=false)]
                public string SliderColor { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// <para>This parameter is required.</para>
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
            public CreateSliderCaptchaPageRequestConfigsZh Zh { get; set; }
            public class CreateSliderCaptchaPageRequestConfigsZh : TeaModel {
                /// <summary>
                /// <para>Specifies whether to show the footer.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ShowFooter")]
                [Validation(Required=false)]
                public bool? ShowFooter { get; set; }

                /// <summary>
                /// <para>Specifies whether to show the request ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ShowRequestId")]
                [Validation(Required=false)]
                public bool? ShowRequestId { get; set; }

                /// <summary>
                /// <para>The color of the slider.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFFFFF</para>
                /// </summary>
                [NameInMap("SliderColor")]
                [Validation(Required=false)]
                public string SliderColor { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// <para>This parameter is required.</para>
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
        /// <para>The custom slider configurations. The value is a JSON string.</para>
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
        /// <para>The name of the custom slider page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of bound site IDs.</para>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public List<long?> SiteIds { get; set; }

    }

}
