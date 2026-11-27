// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppStreamingOutTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. You can create and query it in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wv7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamingOutTemplate")]
        [Validation(Required=false)]
        public ModifyAppStreamingOutTemplateRequestStreamingOutTemplate StreamingOutTemplate { get; set; }
        public class ModifyAppStreamingOutTemplateRequestStreamingOutTemplate : TeaModel {
            /// <summary>
            /// <para>List of layout IDs. A maximum of 16 IDs are allowed.</para>
            /// <para>Note: The data sources corresponding to the layouts in the list must not have the same quantity.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>Encoding options.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>Template Name.</para>
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
