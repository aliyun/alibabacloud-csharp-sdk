// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class GenerateVideoAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DurationAdaption")]
        [Validation(Required=false)]
        public bool? DurationAdaption { get; set; }

        /// <summary>
        /// <para>1</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<GenerateVideoAdvanceRequestFileList> FileList { get; set; }
        public class GenerateVideoAdvanceRequestFileList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1-video1.mp4</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/videoenhan/GenerateVideo/1-video1.mp4">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/videoenhan/GenerateVideo/1-video1.mp4</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public Stream FileUrlObject { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>640</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Mute")]
        [Validation(Required=false)]
        public bool? Mute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PuzzleEffect")]
        [Validation(Required=false)]
        public bool? PuzzleEffect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>costume</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SmartEffect")]
        [Validation(Required=false)]
        public bool? SmartEffect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fast</para>
        /// </summary>
        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>brush</para>
        /// </summary>
        [NameInMap("TransitionStyle")]
        [Validation(Required=false)]
        public string TransitionStyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>640</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
