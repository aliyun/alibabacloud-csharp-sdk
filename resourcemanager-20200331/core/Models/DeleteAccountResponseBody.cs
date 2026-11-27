// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DeleteAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The deletion type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Direct deletion. If the member does not have pay-as-you-go resources within the last 30 days, the system directly deletes the member.</description></item>
        /// <item><description>1: Deletion after a cool-down period. If the member has pay-as-you-go resources within the last 30 days, the member enters a cool-down period. The system starts to delete the member only after the cool-down period ends. For more information about the cool-down period, see <a href="https://help.aliyun.com/document_detail/446079.html">What is the cool-down period for member deletion</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DeletionType")]
        [Validation(Required=false)]
        public string DeletionType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>009429F8-C1C0-5872-B674-A6C2333B9647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
