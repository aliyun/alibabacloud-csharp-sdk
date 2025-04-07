// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0.Models
{
    public class PushDeviceNotificationRequest : TeaModel {
        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public PushDeviceNotificationRequestTenantInfo TenantInfo { get; set; }
        public class PushDeviceNotificationRequestTenantInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12797******304102</para>
            /// </summary>
            [NameInMap("SubjectId")]
            [Validation(Required=false)]
            public string SubjectId { get; set; }

        }

        [NameInMap("body")]
        [Validation(Required=false)]
        public PushDeviceNotificationRequestBody Body { get; set; }
        public class PushDeviceNotificationRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1923792******8R7392</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2iU81*****G9elJ</para>
            /// </summary>
            [NameInMap("MessageTemplateId")]
            [Validation(Required=false)]
            public string MessageTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>29837******2938</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaceHolder { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SendTarget")]
            [Validation(Required=false)]
            public PushDeviceNotificationRequestBodySendTarget SendTarget { get; set; }
            public class PushDeviceNotificationRequestBodySendTarget : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2VpiDQ6aMjxz******Eo7r6e08oIVZ3fKrm5TyEfY=</para>
                /// </summary>
                [NameInMap("TargetIdentity")]
                [Validation(Required=false)]
                public string TargetIdentity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEVICE_OPEN_ID</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

    }

}
