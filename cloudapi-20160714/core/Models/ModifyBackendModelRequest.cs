// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyBackendModelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20bcdc9453524b78a8beb1f6de21edb7</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;ServiceAddress\&quot;:\&quot;<a href="http://121.40.XX.XX%5C%5C%22%7D">http://121.40.XX.XX\\&quot;}</a></para>
        /// </summary>
        [NameInMap("BackendModelData")]
        [Validation(Required=false)]
        public string BackendModelData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3bb6375bc71c4e4c95ce05b4e7a55a9d</para>
        /// </summary>
        [NameInMap("BackendModelId")]
        [Validation(Required=false)]
        public string BackendModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("BackendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>modify plugin first</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
