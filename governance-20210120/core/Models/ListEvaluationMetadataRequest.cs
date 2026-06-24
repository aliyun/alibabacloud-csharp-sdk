// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetadataRequest : TeaModel {
        [NameInMap("EvaluationDomain")]
        [Validation(Required=false)]
        public string EvaluationDomain { get; set; }

        /// <summary>
        /// <para>The language type. Governance evaluation definitions are returned in this language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English.</description></item>
        /// <item><description>zh: Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The specialized evaluation code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>basic (default): foundation model (governance maturity) evaluation.</description></item>
        /// <item><description>ack: container building specialized evaluation.</description></item>
        /// <item><description>ai: machine learning specialized evaluation.</description></item>
        /// <item><description>nis: network service specialized evaluation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ack</para>
        /// </summary>
        [NameInMap("LensCode")]
        [Validation(Required=false)]
        public string LensCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The governance topic code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceUtilization</para>
        /// </summary>
        [NameInMap("TopicCode")]
        [Validation(Required=false)]
        public string TopicCode { get; set; }

    }

}
