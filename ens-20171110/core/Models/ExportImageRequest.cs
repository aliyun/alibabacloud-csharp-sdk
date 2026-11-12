// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportImageRequest : TeaModel {
        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5ragaz3s74b7go8ks7jp9****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The OSS bucket used to store the exported image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whxyl****</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <para>The prefix of the OSS object. The prefix must be 1 to 30 characters in length and can contain letters and digits.</para>
        /// </summary>
        [NameInMap("OSSPrefix")]
        [Validation(Required=false)]
        public string OSSPrefix { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OSSRegionId")]
        [Validation(Required=false)]
        public string OSSRegionId { get; set; }

        /// <summary>
        /// <para>The name of the authorized role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunMNSLoggingRole</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
