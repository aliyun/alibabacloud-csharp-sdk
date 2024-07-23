// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaCensorJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hello world</para>
        /// </summary>
        [NameInMap("Barrages")]
        [Validation(Required=false)]
        public string Barrages { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Bucket&quot;:&quot;example-bucket-<b><b>&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example-</b></b>.jpeg&quot;,&quot;RoleArn&quot;:&quot;acs:ram::1997018457688683:role/AliyunICEDefaultRole&quot;}]</para>
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImages { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestInput Input { get; set; }
        public class SubmitMediaCensorJobRequestInput : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1b1b9cd148034739af413150fded****</para>
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
        /// <para>mns://125340688170****.oss-cn-shanghai.aliyuncs.com/queues/example-pipeline</para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://sashimi-cn-shanghai/censor/snapshot-{Count}.jpg</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitMediaCensorJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5246b8d12a62433ab77845074039****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>S00000001-100060</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Hello World</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserDatatestid-001-****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
