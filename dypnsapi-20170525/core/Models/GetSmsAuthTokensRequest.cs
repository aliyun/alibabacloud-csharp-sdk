// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetSmsAuthTokensRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the iOS application. This parameter is required if OsType is set to <b>iOS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The validity period of the token. Unit: seconds. Valid values: 900 to 43200.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>The type of the operating system. Valid values: <b>Android</b> and <b>iOS</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The package name. This parameter is required if OsType is set to <b>Android</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliqin.mytel.test</para>
        /// </summary>
        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC100000134840112</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The signature. This parameter is required if OsType is set to <b>Android</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47fcc6615485e83b4100433****</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The validity period of the SMS verification code. Unit: seconds. Default value: 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("SmsCodeExpire")]
        [Validation(Required=false)]
        public int? SmsCodeExpire { get; set; }

        /// <summary>
        /// <para>The code of the text message template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_13987****</para>
        /// </summary>
        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

    }

}
