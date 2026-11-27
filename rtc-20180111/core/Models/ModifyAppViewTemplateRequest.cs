// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppViewTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. Create and view it in the console. Only one ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wv7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public ModifyAppViewTemplateRequestTemplate Template { get; set; }
        public class ModifyAppViewTemplateRequestTemplate : TeaModel {
            /// <summary>
            /// <para>List of layout IDs. Maximum of 16 IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>Encoding option.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>Template name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模板</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac7N****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
