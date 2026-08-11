// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateFlashSmsAccessProfileRequest : TeaModel {
        /// <summary>
        /// <para>The access configuration.</para>
        /// </summary>
        [NameInMap("AccessProfile")]
        [Validation(Required=false)]
        public UpdateFlashSmsAccessProfileRequestAccessProfile AccessProfile { get; set; }
        public class UpdateFlashSmsAccessProfileRequestAccessProfile : TeaModel {
            /// <summary>
            /// <para>Required when ProviderId is set to ShangHaiTianNan or Uincall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6004200267</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChinaMobile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TQChVEAabhaNp2AB</para>
            /// </summary>
            [NameInMap("AesKey")]
            [Validation(Required=false)]
            public string AesKey { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChuangLan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N92685567</para>
            /// </summary>
            [NameInMap("ApiAccount")]
            [Validation(Required=false)]
            public string ApiAccount { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChinaMobile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100235</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChinaMobile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3aRsPrTsDG3OPNq5</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChuangLan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rp7hyUbtXMef23</para>
            /// </summary>
            [NameInMap("ApiPassword")]
            [Validation(Required=false)]
            public string ApiPassword { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChinaMobile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300012117547</para>
            /// </summary>
            [NameInMap("CapAppId")]
            [Validation(Required=false)]
            public string CapAppId { get; set; }

            /// <summary>
            /// <para>The list of Alibaba Communication configurations. Required when ProviderId is set to DySms.</para>
            /// </summary>
            [NameInMap("DySmsAccessProfiles")]
            [Validation(Required=false)]
            public List<UpdateFlashSmsAccessProfileRequestAccessProfileDySmsAccessProfiles> DySmsAccessProfiles { get; set; }
            public class UpdateFlashSmsAccessProfileRequestAccessProfileDySmsAccessProfiles : TeaModel {
                /// <summary>
                /// <para>The template content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>We tried to reach you but you were unavailable. Our staff will contact you again shortly. We apologize for any inconvenience</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The signature name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud Call Center</para>
                /// </summary>
                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                /// <summary>
                /// <para>The template code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS_469075249</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <para>Required when ProviderId is set to ShangHaiTianNan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10690101220</para>
            /// </summary>
            [NameInMap("Extno")]
            [Validation(Required=false)]
            public string Extno { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChuangLan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rp7hyUbtXMef23</para>
            /// </summary>
            [NameInMap("ManagementPassword")]
            [Validation(Required=false)]
            public string ManagementPassword { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChuangLan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chuanglanrobot2</para>
            /// </summary>
            [NameInMap("ManagementSubUserId")]
            [Validation(Required=false)]
            public string ManagementSubUserId { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ChuangLan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chuanglanrobot</para>
            /// </summary>
            [NameInMap("ManagementUsername")]
            [Validation(Required=false)]
            public string ManagementUsername { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to ShangHaiTianNan or HeDao.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nu2DxxfZtY46</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to Uincall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>828ee92ebc8241d3b37d0238dde6345e</para>
            /// </summary>
            [NameInMap("Pwd")]
            [Validation(Required=false)]
            public string Pwd { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to Uincall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6004200267_dev</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>Required when ProviderId is set to HeDao.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST10</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The access configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The provider ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uincall: Beijing Youyin Communication Co., Ltd.</description></item>
        /// <item><description>ChuangLan: Beijing Chuanglan Cloud Intelligence Information Co., Ltd.</description></item>
        /// <item><description>ChinaMobile: China Mobile.</description></item>
        /// <item><description>ShangHaiTianNan: Shanghai Tiannan.</description></item>
        /// <item><description>HeDao: Galaxis.</description></item>
        /// <item><description>DySms: Alibaba Communication.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Uincall</para>
        /// </summary>
        [NameInMap("ProviderId")]
        [Validation(Required=false)]
        public string ProviderId { get; set; }

    }

}
