// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. You can use this field to determine the cause of the failure.</para>
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
        public UpdateTagResponseBodyData Data { get; set; }
        public class UpdateTagResponseBodyData : TeaModel {
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
            /// <para>涵盖退款、退货、维修、咨询等售后链路</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the label node was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748431368000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>售后服务</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parent label node.</para>
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
        /// <para>The error message returned when an error occurs.</para>
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
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
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
