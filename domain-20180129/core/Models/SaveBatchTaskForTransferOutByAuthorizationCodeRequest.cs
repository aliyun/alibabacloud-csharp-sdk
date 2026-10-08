// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForTransferOutByAuthorizationCodeRequest : TeaModel {
        /// <summary>
        /// <para>A list of domain names to transfer out, each with its authorization code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SaveBatchTaskForTransferOutByAuthorizationCode</para>
        /// </summary>
        [NameInMap("TransferOutParamList")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForTransferOutByAuthorizationCodeRequestTransferOutParamList> TransferOutParamList { get; set; }
        public class SaveBatchTaskForTransferOutByAuthorizationCodeRequestTransferOutParamList : TeaModel {
            /// <summary>
            /// <para>The authorization code for the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test2o#Lck</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <para>The domain name to transfer out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

    }

}
