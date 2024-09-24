// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDynamicDictResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of weak password rules that are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The name of the OSS object that contains custom weak passwords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_dict.plain</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The size of the OSS object. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The maximum number of weak password rules that can be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The IP address of the Object Storage Service (OSS) object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudtest01/661767e1-5ae3-4ec5-865f-03039436893a/sacc2*****</para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timestamp when the OSS object was uploaded. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719919421</para>
        /// </summary>
        [NameInMap("UploadTime")]
        [Validation(Required=false)]
        public long? UploadTime { get; set; }

    }

}
