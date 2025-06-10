// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunCTRegistrationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunCTRegistrationResponseBodyData Data { get; set; }
        public class RunCTRegistrationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/chest-ct-registration/ctctreg/2020-09-05_13%3A59%3A59_894c42d0-876a-9198-9fd9-09431fb96fad.tar.gz?Expires=1599287399&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=cWTQtdb7geuEJ46cNO%2BGGimrN">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/chest-ct-registration/ctctreg/2020-09-05_13%3A59%3A59_894c42d0-876a-9198-9fd9-09431fb96fad.tar.gz?Expires=1599287399&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=cWTQtdb7geuEJ46cNO%2BGGimrN</a>****</para>
            /// </summary>
            [NameInMap("DUrl")]
            [Validation(Required=false)]
            public string DUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/chest-ct-registration/ctctreg/2020-09-05_13%3A59%3A59_894c42d0-876a-9198-9fd9-09431fb96fad.nii.gz?Expires=1599287399&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=Tgjk1WsZFvvyIUMunxizNtivhY">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/chest-ct-registration/ctctreg/2020-09-05_13%3A59%3A59_894c42d0-876a-9198-9fd9-09431fb96fad.nii.gz?Expires=1599287399&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=Tgjk1WsZFvvyIUMunxizNtivhY</a>****</para>
            /// </summary>
            [NameInMap("NUrl")]
            [Validation(Required=false)]
            public string NUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EB3ACFE6-EA75-49E1-83C0-953580F74D88</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
