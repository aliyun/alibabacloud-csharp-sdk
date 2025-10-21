// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelInputContentSyncDetectRequest : TeaModel {
        /// <summary>
        /// <para>Request object</para>
        /// </summary>
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public ModelInputContentSyncDetectRequestBodyData BodyData { get; set; }
        public class ModelInputContentSyncDetectRequestBodyData : TeaModel {
            /// <summary>
            /// <ol>
            /// <item><description>The text content to be checked, with a maximum limit of 10,000 characters (including English and Chinese).</description></item>
            /// <item><description>Or the URL address of the image to be checked.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>要检测的内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>Policy Identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>x1bc5xgs4uhx</para>
        /// </summary>
        [NameInMap("PolicyIdentifier")]
        [Validation(Required=false)]
        public string PolicyIdentifier { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Scene name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>Service name</para>
        /// 
        /// <b>Example:</b>
        /// <para>textDetection
        /// imageDetection</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
