// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingGenerationDay : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ArticleTasks")]
        [Validation(Required=false)]
        public long? ArticleTasks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-11-26</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ImageTasks")]
        [Validation(Required=false)]
        public long? ImageTasks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VideoTasks")]
        [Validation(Required=false)]
        public long? VideoTasks { get; set; }

    }

}
