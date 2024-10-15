// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SetTransferCalleePoolConfigRequest : TeaModel {
        /// <summary>
        /// <para>The call mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>roundRobin</b></description></item>
        /// <item><description><b>random</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>roundRobin</para>
        /// </summary>
        [NameInMap("CalledRouteMode")]
        [Validation(Required=false)]
        public string CalledRouteMode { get; set; }

        /// <summary>
        /// <para>The information about the phone numbers for transferring the call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<SetTransferCalleePoolConfigRequestDetails> Details { get; set; }
        public class SetTransferCalleePoolConfigRequestDetails : TeaModel {
            /// <summary>
            /// <para>The called number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151****0000</para>
            /// </summary>
            [NameInMap("Called")]
            [Validation(Required=false)]
            public string Called { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150****0000</para>
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The phone number used for transferring the call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400****</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The qualification ID. You can call the <a href="https://help.aliyun.com/document_detail/393548.html">GetHotlineQualificationByOrder</a> operation to obtain the qualification ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>190***</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
