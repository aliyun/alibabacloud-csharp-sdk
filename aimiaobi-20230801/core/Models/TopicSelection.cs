// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class TopicSelection : TeaModel {
        /// <summary>
        /// <para>A list of topic outlines.</para>
        /// </summary>
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<TopicSelectionOutlines> Outlines { get; set; }
        public class TopicSelectionOutlines : TeaModel {
            /// <summary>
            /// <para>The topic outline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>大纲</para>
            /// </summary>
            [NameInMap("Outline")]
            [Validation(Required=false)]
            public string Outline { get; set; }

            /// <summary>
            /// <para>The summary of the outline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        /// <summary>
        /// <para>The perspective of the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>选题视角</para>
        /// </summary>
        [NameInMap("Point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        /// <summary>
        /// <para>The summary of the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>摘要</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
