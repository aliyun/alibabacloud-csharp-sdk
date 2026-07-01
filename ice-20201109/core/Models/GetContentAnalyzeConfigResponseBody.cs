// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetContentAnalyzeConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration for Intelligent Content Analysis.</para>
        /// </summary>
        [NameInMap("ContentAnalyzeConfig")]
        [Validation(Required=false)]
        public GetContentAnalyzeConfigResponseBodyContentAnalyzeConfig ContentAnalyzeConfig { get; set; }
        public class GetContentAnalyzeConfigResponseBodyContentAnalyzeConfig : TeaModel {
            /// <summary>
            /// <para>Specifies if Intelligent Content Analysis starts automatically after a Media Asset is registered.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disabled. (default)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// <para>The repository type for saving analysis results. This parameter is valid only when <c>Auto</c> is set to <c>true</c>. The default is an empty string.</para>
            /// <list type="bullet">
            /// <item><description><para><c>TEXT</c>: Label</para>
            /// </description></item>
            /// <item><description><para><c>FACE</c>: Face</para>
            /// </description></item>
            /// <item><description><para><c>DNA</c>: Image DNA</para>
            /// </description></item>
            /// </list>
            /// <para>You can specify multiple values, separated by commas (,). If this parameter is left empty, the analysis results are not saved to any search repository and cannot be used for content search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT,FACE</para>
            /// </summary>
            [NameInMap("SaveType")]
            [Validation(Required=false)]
            public string SaveType { get; set; }

            /// <summary>
            /// <para>The ID of the Intelligent Content Analysis template. Each template includes the following AI capabilities:</para>
            /// <list type="bullet">
            /// <item><description><para><c>S00000101-100040</c>: Text Recognition</para>
            /// </description></item>
            /// <item><description><para><c>S00000101-100060</c>: Video Classification and Face Recognition</para>
            /// </description></item>
            /// <item><description><para><c>S00000101-100070</c>: Text Recognition, Video Classification, and Face Recognition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S00000101-100070</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31FEC819-2344-5771-9366-9172DB0D26C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
