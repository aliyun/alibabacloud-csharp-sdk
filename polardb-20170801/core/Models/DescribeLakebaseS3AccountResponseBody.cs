// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLakebaseS3AccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD3FA5F3-FAF3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Access Key of the S3 account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accname</para>
        /// </summary>
        [NameInMap("UserAccAk")]
        [Validation(Required=false)]
        public string UserAccAk { get; set; }

        /// <summary>
        /// <para>The policy document of the S3 account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;2012-10-17&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:[&quot;s3:<em>&quot;],&quot;Resource&quot;:[&quot;</em>&quot;]}]}</para>
        /// </summary>
        [NameInMap("UserAccPolicy")]
        [Validation(Required=false)]
        public string UserAccPolicy { get; set; }

        /// <summary>
        /// <para>The Secret Key of the S3 account (masked).</para>
        /// 
        /// <b>Example:</b>
        /// <para>password***</para>
        /// </summary>
        [NameInMap("UserAccSk")]
        [Validation(Required=false)]
        public string UserAccSk { get; set; }

    }

}
