// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ImportDoNotCallNumbersRequest : TeaModel {
        /// <summary>
        /// <para>The key of the OSS file. You can obtain the key from the response of the GetDoNotCallFileUploadParameters API. This parameter is required only for file uploads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp/blacklist/import/15772471154xxxx/ccc-test/20220315100340/blacklist.xlsx</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A JSON string that represents an array of do-not-call numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1900000****&quot;,&quot;1312121****&quot;]</para>
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        /// <summary>
        /// <para>The remark for the do-not-call numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
