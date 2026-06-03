// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class CreateSchemeConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>com.aliyun.android</para>
        /// </summary>
        [NameInMap("AndroidPackageName")]
        [Validation(Required=false)]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dfsfaawklll1*<em><b>olkweklk</b></em></para>
        /// </summary>
        [NameInMap("AndroidPackageSign")]
        [Validation(Required=false)]
        public string AndroidPackageSign { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>阿里云通信</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("H5Origin")]
        [Validation(Required=false)]
        public string H5Origin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("H5Url")]
        [Validation(Required=false)]
        public string H5Url { get; set; }

        /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android APP测试方案</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

    }

}
