// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class FindIdpListByLoginIdentifierShrinkRequest : TeaModel {
        [NameInMap("AvailableFeatures")]
        [Validation(Required=false)]
        public string AvailableFeaturesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc</para>
        /// </summary>
        [NameInMap("ClientChannel")]
        [Validation(Required=false)]
        public string ClientChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>370b56f8-2812-4b6c-bfa6-2560791c****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22.21.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>windows_\&quot;Windows 10 Enterprise\&quot; 10.0 (Build 14393)</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0.1-D-20211008.101607</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun123***</para>
        /// </summary>
        [NameInMap("LoginIdentifier")]
        [Validation(Required=false)]
        public string LoginIdentifier { get; set; }

        [NameInMap("SupportTypes")]
        [Validation(Required=false)]
        public List<string> SupportTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2943802884B27030B6759F9132B2****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
