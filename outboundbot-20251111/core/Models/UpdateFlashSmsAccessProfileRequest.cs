// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateFlashSmsAccessProfileRequest : TeaModel {
        /// <summary>
        /// <para>接入配置</para>
        /// </summary>
        [NameInMap("AccessProfile")]
        [Validation(Required=false)]
        public UpdateFlashSmsAccessProfileRequestAccessProfile AccessProfile { get; set; }
        public class UpdateFlashSmsAccessProfileRequestAccessProfile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6004200267</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TQChVEAabhaNp2AB</para>
            /// </summary>
            [NameInMap("AesKey")]
            [Validation(Required=false)]
            public string AesKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N92685567</para>
            /// </summary>
            [NameInMap("ApiAccount")]
            [Validation(Required=false)]
            public string ApiAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100235</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3aRsPrTsDG3OPNq5</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Rp7hyUbtXMef23</para>
            /// </summary>
            [NameInMap("ApiPassword")]
            [Validation(Required=false)]
            public string ApiPassword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300012117547</para>
            /// </summary>
            [NameInMap("CapAppId")]
            [Validation(Required=false)]
            public string CapAppId { get; set; }

            [NameInMap("DySmsAccessProfiles")]
            [Validation(Required=false)]
            public List<UpdateFlashSmsAccessProfileRequestAccessProfileDySmsAccessProfiles> DySmsAccessProfiles { get; set; }
            public class UpdateFlashSmsAccessProfileRequestAccessProfileDySmsAccessProfiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>我们联系您，您不在，稍后工作人员会继续联系您，如有打扰，请见谅</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>云呼叫中心</para>
                /// </summary>
                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SMS_469075249</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10690101220</para>
            /// </summary>
            [NameInMap("Extno")]
            [Validation(Required=false)]
            public string Extno { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Rp7hyUbtXMef23</para>
            /// </summary>
            [NameInMap("ManagementPassword")]
            [Validation(Required=false)]
            public string ManagementPassword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chuanglanrobot2</para>
            /// </summary>
            [NameInMap("ManagementSubUserId")]
            [Validation(Required=false)]
            public string ManagementSubUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chuanglanrobot</para>
            /// </summary>
            [NameInMap("ManagementUsername")]
            [Validation(Required=false)]
            public string ManagementUsername { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nu2DxxfZtY46</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>828ee92ebc8241d3b37d0238dde6345e</para>
            /// </summary>
            [NameInMap("Pwd")]
            [Validation(Required=false)]
            public string Pwd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6004200267_dev</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TEST10</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>接入配置ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <para>实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>供应商ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>Uincall</para>
        /// </summary>
        [NameInMap("ProviderId")]
        [Validation(Required=false)]
        public string ProviderId { get; set; }

    }

}
