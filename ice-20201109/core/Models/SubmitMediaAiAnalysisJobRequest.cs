// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaAiAnalysisJobRequest : TeaModel {
        /// <summary>
        /// <para>The analysis parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nlpParams&quot;:{&quot;sourceLanguage&quot;:&quot;cn&quot;,&quot;diarizationEnabled&quot;:true,&quot;speakerCount&quot;:0,&quot;summarizationEnabled&quot;:false,&quot;translationEnabled&quot;:false}}</para>
        /// </summary>
        [NameInMap("AnalysisParams")]
        [Validation(Required=false)]
        public string AnalysisParams { get; set; }

        /// <summary>
        /// <para>The media asset that you want to analyze. You can specify an Object Storage Service (OSS) URL, a media asset ID, or an external URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaType&quot;:&quot;video&quot;,&quot;Media&quot;:&quot;<a href="https://xxx.com/your_movie.mp4%22%7D">https://xxx.com/your_movie.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
