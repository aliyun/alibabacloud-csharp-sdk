// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BatchGetAcpConnectionTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of the instance connection tasks.</para>
        /// </summary>
        [NameInMap("InstanceConnectionModels")]
        [Validation(Required=false)]
        public List<BatchGetAcpConnectionTicketResponseBodyInstanceConnectionModels> InstanceConnectionModels { get; set; }
        public class BatchGetAcpConnectionTicketResponseBodyInstanceConnectionModels : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-1uzb6heg797z3****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The ID of the cloud phone instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-ajxvwo1u0hqvd****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PersistentAppInstanceId")]
            [Validation(Required=false)]
            public string PersistentAppInstanceId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou@c9f5c2e8-f5c4-4b01-8602-000cae94****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The state of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The ticket used to connect to the cloud phone instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>piVE58_AdmVSVW7SEW3<em>AE5</em>p8mmO5gvItsNOmv4S_f_cNpoU_BOTwChTBoNM1ZJeedfK9zxYnbN5hossqIZCr6t7SGxRigm2Cb4fGaCdBZWIzmgdHq6sXXZQg4KFWufyvpeV<em>0</em>Cm58slMT1tJw3****</para>
            /// </summary>
            [NameInMap("Ticket")]
            [Validation(Required=false)]
            public string Ticket { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B9EFA4F-4305-5968-BAEE-BD8B8DE5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
