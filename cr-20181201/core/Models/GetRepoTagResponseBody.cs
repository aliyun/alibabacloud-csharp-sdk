// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The digest value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67bfbcc12b67936ec7f867927817cbb071832b873dbcaed312a1930ba5f1****</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The time when the image was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1572839125000</para>
        /// </summary>
        [NameInMap("ImageCreate")]
        [Validation(Required=false)]
        public long? ImageCreate { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45023655bf39c382e26a8607d057c27871dee163c1ecf48cc1ebf2a1****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The size of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27107966</para>
        /// </summary>
        [NameInMap("ImageSize")]
        [Validation(Required=false)]
        public long? ImageSize { get; set; }

        /// <summary>
        /// <para>The time when the image was last updated. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1572875608000</para>
        /// </summary>
        [NameInMap("ImageUpdate")]
        [Validation(Required=false)]
        public long? ImageUpdate { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>031572FA-7D8F-4C05-B790-1071E0E05DE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NORMAL</c>: Normal.</para>
        /// </description></item>
        /// <item><description><para><c>DELETING</c>: The image is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The repository tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
