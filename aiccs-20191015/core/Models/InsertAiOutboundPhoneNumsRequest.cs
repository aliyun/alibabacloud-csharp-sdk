// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertAiOutboundPhoneNumsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BatchVersion")]
        [Validation(Required=false)]
        public int? BatchVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<InsertAiOutboundPhoneNumsRequestDetails> Details { get; set; }
        public class InsertAiOutboundPhoneNumsRequestDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>150****0000</para>
            /// </summary>
            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
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
