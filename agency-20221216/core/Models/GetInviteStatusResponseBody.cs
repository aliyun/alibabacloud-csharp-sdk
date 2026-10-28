// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetInviteStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Error code: 3057: InviteId is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInviteStatusResponseBodyData Data { get; set; }
        public class GetInviteStatusResponseBodyData : TeaModel {
            [NameInMap("InviteStatus")]
            [Validation(Required=false)]
            public List<GetInviteStatusResponseBodyDataInviteStatus> InviteStatus { get; set; }
            public class GetInviteStatusResponseBodyDataInviteStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("InviteStatusList")]
                [Validation(Required=false)]
                public GetInviteStatusResponseBodyDataInviteStatusInviteStatusList InviteStatusList { get; set; }
                public class GetInviteStatusResponseBodyDataInviteStatusInviteStatusList : TeaModel {
                    [NameInMap("AssociationSuccessTime")]
                    [Validation(Required=false)]
                    public string AssociationSuccessTime { get; set; }

                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public long? Cid { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("SubAccountType")]
                    [Validation(Required=false)]
                    public string SubAccountType { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud uses this ID for error tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values: true and false. This parameter does not indicate whether subsequent business operations are successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
