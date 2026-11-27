// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertAiOutboundPhoneNumsRequest : TeaModel {
        /// <summary>
        /// <para>The task batch number.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the numbers are imported to the default batch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BatchVersion")]
        [Validation(Required=false)]
        public int? BatchVersion { get; set; }

        /// <summary>
        /// <para>The number details.</para>
        /// <remarks>
        /// <para>A maximum of 30 entries are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<InsertAiOutboundPhoneNumsRequestDetails> Details { get; set; }
        public class InsertAiOutboundPhoneNumsRequestDetails : TeaModel {
            /// <summary>
            /// <para>The custom business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ioi-qerhne-hoz-114c</para>
            /// </summary>
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            /// <summary>
            /// <para>The outbound called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150****0000</para>
            /// </summary>
            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

        }

        /// <summary>
        /// <para>The AICCS instance ID.
        /// You can obtain the instance ID in the <b>Instances</b> section of the left-side navigation pane in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/312260.html">CreateAiOutboundTask</a> operation and view the <b>Data</b> response parameter, or call the <a href="https://help.aliyun.com/document_detail/2718026.html">GetAiOutboundTaskList</a> operation and view the <b>TaskId</b> response parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
