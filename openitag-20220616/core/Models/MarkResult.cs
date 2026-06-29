// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class MarkResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether voting is required. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>True: Yes  </description></item>
        /// <item><description>False: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsNeedVoteJudge")]
        [Validation(Required=false)]
        public bool? IsNeedVoteJudge { get; set; }

        /// <summary>
        /// <para>Question result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b</para>
        /// </summary>
        [NameInMap("MarkResult")]
        [Validation(Required=false)]
        public string MarkResult_ { get; set; }

        /// <summary>
        /// <para>Question ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500***849089597440</para>
        /// </summary>
        [NameInMap("MarkResultId")]
        [Validation(Required=false)]
        public string MarkResultId { get; set; }

        /// <summary>
        /// <para>Annotation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mon Mar 07 17:02:48 CST 2022</para>
        /// </summary>
        [NameInMap("MarkTime")]
        [Validation(Required=false)]
        public string MarkTime { get; set; }

        /// <summary>
        /// <para>Question name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>单选</para>
        /// </summary>
        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        /// <summary>
        /// <para>Progress. The return value is either None or data of JSON type. It includes:  </para>
        /// <list type="bullet">
        /// <item><description>Total: total number of results.  </description></item>
        /// <item><description>Finished: number of completed results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        /// <summary>
        /// <para>Attached question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QuestionId")]
        [Validation(Required=false)]
        public string QuestionId { get; set; }

        /// <summary>
        /// <para>Result type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>RADIO: Radio  </description></item>
        /// <item><description>SLOT: Segment  </description></item>
        /// <item><description>INPUT: Fill-in-the-blank  </description></item>
        /// <item><description>CHECKBOX: Multiple Choice</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RADIO</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>User annotation result ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500***849358032896</para>
        /// </summary>
        [NameInMap("UserMarkResultId")]
        [Validation(Required=false)]
        public string UserMarkResultId { get; set; }

        /// <summary>
        /// <para>Version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646643768468</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
