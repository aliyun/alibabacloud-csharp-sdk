// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVolDingdingMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The QR code address of the DingTalk group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.wikihow.com/images_en/thumb/4/48/Get-the-URL-for-Pictures-Step-4-Version-4.jpg/v4-728px-Get-the-URL-for-Pictures-Step-4-Version-4.jpg.webp">https://www.wikihow.com/images_en/thumb/4/48/Get-the-URL-for-Pictures-Step-4-Version-4.jpg/v4-728px-Get-the-URL-for-Pictures-Step-4-Version-4.jpg.webp</a></para>
        /// </summary>
        [NameInMap("DingdingUrl")]
        [Validation(Required=false)]
        public string DingdingUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A437E93-47EE-548F-ABCE-13F89AA85585</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
