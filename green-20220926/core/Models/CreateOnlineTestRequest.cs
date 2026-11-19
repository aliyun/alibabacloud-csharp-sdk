// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreateOnlineTestRequest : TeaModel {
        /// <summary>
        /// <para>The data ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f27b8cc7c4544cb90b41882a5b36326</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values: voice (audio), image (image), file (document), text (text), and video (video).</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service code. Specify a valid service code. The valid service code for online video testing is videoDetection. VideoModeration is not a valid value and returns a 406 online.test.failed error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videoDetection</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The detection URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxxxx.com/data/data.png">https://xxxxxxxxxx.com/data/data.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
