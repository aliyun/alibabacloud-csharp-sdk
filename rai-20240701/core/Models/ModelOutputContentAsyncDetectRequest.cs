// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelOutputContentAsyncDetectRequest : TeaModel {
        /// <summary>
        /// <para>Request object</para>
        /// </summary>
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public ModelOutputContentAsyncDetectRequestBodyData BodyData { get; set; }
        public class ModelOutputContentAsyncDetectRequestBodyData : TeaModel {
            /// <summary>
            /// <ol>
            /// <item><description>The text content to be reviewed, with a maximum limit of 10000 characters (including English and Chinese).</description></item>
            /// <item><description>Or the URL address of the image to be reviewed.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>the content to be checked</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>Policy ID</para>
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
