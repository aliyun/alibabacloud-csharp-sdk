// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class GetOssStsTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>STS.NZeNA1kdCm4QPuAJ9kN******</para>
        /// </summary>
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9EStV7fgkSQsPuBi576EmNQXLxJGddL2EGyX********</para>
        /// </summary>
        [NameInMap("AccessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prod-wy-*****</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("ObjectKeyPrefix")]
        [Validation(Required=false)]
        public string ObjectKeyPrefix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou</para>
        /// </summary>
        [NameInMap("OssRegion")]
        [Validation(Required=false)]
        public string OssRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAISvAN1q6Ft5B2yfSjIr5n2Bez81ZRTgqOGZn6FkHBnXf9qgI6apjz2IH*******</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
