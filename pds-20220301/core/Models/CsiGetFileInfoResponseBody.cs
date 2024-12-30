// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CsiGetFileInfoResponseBody : TeaModel {
        [NameInMap("investigation_info")]
        [Validation(Required=false)]
        public InvestigationInfo InvestigationInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
