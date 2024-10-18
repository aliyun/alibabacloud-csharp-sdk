// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetFusionAuthTokenRequest : TeaModel {
        /// <summary>
        /// <para>The bundle ID of the app. This parameter is required when Platform is set to iOS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.example.test</para>
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
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The package name of the app. This parameter is required when Platform is set to Android.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.example.test</para>
        /// </summary>
        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        /// <summary>
        /// <para>The package signature of the app. This parameter is required when Platform is set to Android.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47fcc************************278</para>
        /// </summary>
        [NameInMap("PackageSign")]
        [Validation(Required=false)]
        public string PackageSign { get; set; }

        /// <summary>
        /// <para>The platform type. Valid values: Android and iOS.</para>
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
        /// <para>The service code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA1000*************201</para>
        /// </summary>
        [NameInMap("SchemeCode")]
        [Validation(Required=false)]
        public string SchemeCode { get; set; }

    }

}
