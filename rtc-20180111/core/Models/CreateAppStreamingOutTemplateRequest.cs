// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateAppStreamingOutTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("StreamingOutTemplate")]
        [Validation(Required=false)]
        public CreateAppStreamingOutTemplateRequestStreamingOutTemplate StreamingOutTemplate { get; set; }
        public class CreateAppStreamingOutTemplateRequestStreamingOutTemplate : TeaModel {
            /// <summary>
            /// <para>The list of layout IDs. A maximum of 16 layout IDs are supported.</para>
            /// <para>Note: The layouts in the list must not have the same number of data sources.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>The encoding options.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
