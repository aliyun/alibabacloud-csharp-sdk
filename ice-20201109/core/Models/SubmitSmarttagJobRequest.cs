// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSmarttagJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>example content ****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://123.com/testVideo.mp4">http://123.com/testVideo.mp4</a></para>
        /// </summary>
        [NameInMap("ContentAddr")]
        [Validation(Required=false)]
        public string ContentAddr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>application/zip</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>input</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestInput Input { get; set; }
        public class SubmitSmarttagJobRequestInput : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>c5c62d8f0361337cab312dce8e77dc6d</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/endpoint/aliyun/ai?id=76401125000">https://example.com/endpoint/aliyun/ai?id=76401125000</a>***</para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;needAsrData&quot;:true, &quot;needOcrData&quot;:false}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>scheduleConfig</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSmarttagJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acdbfe4323bcfdae</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example-title-****</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{“a”:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
