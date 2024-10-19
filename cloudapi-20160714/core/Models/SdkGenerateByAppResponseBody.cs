// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SdkGenerateByAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UEsDBBQACAAIADdwnFQAAAAAAAAAAAAAAAA2AAAAQ0FTREtfSkFWQV8xMjI3NDY2NjY0MzM0MTMzXzE2NTExMjU3MD......</para>
        /// </summary>
        [NameInMap("DownloadLink")]
        [Validation(Required=false)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>61A16D46-EC04-5288-8A18-811B0F536CC2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
