// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetAccountInfoRequest : TeaModel {
        /// <summary>
        /// <para>Result Code:</para>
        /// <list type="bullet">
        /// <item><description>200 OK</description></item>
        /// <item><description>1109 System error</description></item>
        /// <item><description>3030 Sub Account Nickname exceeds maximum length,  maximum length 150 bytes.</description></item>
        /// <item><description>3031 Remark exceeds maximum length,  maximum length 3000 bytes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Message information</para>
        /// </summary>
        [NameInMap("AccountNickname")]
        [Validation(Required=false)]
        public string AccountNickname { get; set; }

        /// <summary>
        /// <para>Customer manager（limited 50 character）</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("CustomerBd")]
        [Validation(Required=false)]
        public string CustomerBd { get; set; }

        /// <summary>
        /// <para>success</para>
        /// 
        /// <b>Example:</b>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Request ID, Alibaba Cloud will track errors with this.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
