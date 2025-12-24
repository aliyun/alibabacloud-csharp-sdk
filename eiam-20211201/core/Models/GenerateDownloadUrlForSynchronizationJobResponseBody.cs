// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GenerateDownloadUrlForSynchronizationJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://test.oss.aliyuncs.com/idaas_ly77wa2oexrciw5v672vxxxx/tmp/eiam_user_export_1766469463365.csv">https://test.oss.aliyuncs.com/idaas_ly77wa2oexrciw5v672vxxxx/tmp/eiam_user_export_1766469463365.csv</a></para>
        /// </summary>
        [NameInMap("FileDownloadUrl")]
        [Validation(Required=false)]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
