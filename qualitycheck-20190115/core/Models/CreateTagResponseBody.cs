// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. You can use this field to determine the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTagResponseBodyData Data { get; set; }
        public class CreateTagResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the label node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748428991000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The label description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用于归集售后服务相关的所有意图与 FAQ</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the label node was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748428991000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>售后问题</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parent label node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentTagId")]
            [Validation(Required=false)]
            public long? ParentTagId { get; set; }

            /// <summary>
            /// <para>The label ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

        }

        /// <summary>
        /// <para>The error message, if any.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values: true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
