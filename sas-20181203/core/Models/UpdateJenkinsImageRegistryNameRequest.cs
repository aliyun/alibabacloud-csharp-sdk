// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateJenkinsImageRegistryNameRequest : TeaModel {
        /// <summary>
        /// <para>The image repository ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~PageImageRegistry~~">PageImageRegistry</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>25090</para>
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

        /// <summary>
        /// <para>The image repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a0603tk1</para>
        /// </summary>
        [NameInMap("RegistryName")]
        [Validation(Required=false)]
        public string RegistryName { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.33.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
