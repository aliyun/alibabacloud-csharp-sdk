// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateRenderingInstanceSettingsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public List<UpdateRenderingInstanceSettingsRequestSettings> Settings { get; set; }
        public class UpdateRenderingInstanceSettingsRequestSettings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>navbar.hide</para>
            /// </summary>
            [NameInMap("AttributeName")]
            [Validation(Required=false)]
            public string AttributeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AttributeValue")]
            [Validation(Required=false)]
            public string AttributeValue { get; set; }

        }

    }

}
