// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CreateSchemeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The package name. This parameter is required when Platform is set to Android. The name must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyun.android</para>
        /// </summary>
        [NameInMap("AndroidPackageName")]
        [Validation(Required=false)]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// <para>The package signature. This parameter is required when Platform is set to Android. The signature must be 32 characters in length and can contain digits and letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfsfaawklll1*<em><b>olkweklk</b></em></para>
        /// </summary>
        [NameInMap("AndroidPackageSign")]
        [Validation(Required=false)]
        public string AndroidPackageSign { get; set; }

        /// <summary>
        /// <para>The app name, which can be up to 20 characters in length and can contain letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Communications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The reserved field. HTML5 apps are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("H5Origin")]
        [Validation(Required=false)]
        public string H5Origin { get; set; }

        /// <summary>
        /// <para>The reserved field. HTML5 apps are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("H5Url")]
        [Validation(Required=false)]
        public string H5Url { get; set; }

        /// <summary>
        /// <para>The bundle ID. This parameter is required when OsType is set to iOS. The bundle ID must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyun.ios</para>
        /// </summary>
        [NameInMap("IosBundleId")]
        [Validation(Required=false)]
        public string IosBundleId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The app platform.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Android</description></item>
        /// <item><description>iOS</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The service name, which can be up to 10 characters in length and can contain letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

    }

}
