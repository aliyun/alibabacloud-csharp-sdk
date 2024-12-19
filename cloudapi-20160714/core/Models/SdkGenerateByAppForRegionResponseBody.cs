// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SdkGenerateByAppForRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The code of the SDK by using the Base64 scheme. You can obtain the file by using the Base64 decoding scheme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UEsDBBQACAAIADdwnFQAAAAAAAAAAAAAAAA2AAAAQ0FTREtfSkFWQV8xMjI3NDY2NjY0MzM0MTMzXzE2NTExMjU3MD......</para>
        /// </summary>
        [NameInMap("DownloadLink")]
        [Validation(Required=false)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE5722A6-AE78-4741-A9B0-6C817D360510</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
