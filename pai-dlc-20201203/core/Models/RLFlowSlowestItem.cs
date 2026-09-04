// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowSlowestItem : TeaModel {
        /// <summary>
        /// <para>The UID of the sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>321fa56f-e1e5-4eb3-8047-db7a230c9a75</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

        /// <summary>
        /// <para>The ordinal number of the event trace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SampleIndex")]
        [Validation(Required=false)]
        public string SampleIndex { get; set; }

        /// <summary>
        /// <para>The execution duration of the stage, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9.2</para>
        /// </summary>
        [NameInMap("Sec")]
        [Validation(Required=false)]
        public double? Sec { get; set; }

    }

}
