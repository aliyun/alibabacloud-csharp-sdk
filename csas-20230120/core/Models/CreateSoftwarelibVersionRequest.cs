// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateSoftwarelibVersionRequest : TeaModel {
        /// <summary>
        /// <para>The MD5 value of the software package. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b5824cdd509d3ed560e2d20d29a1bcb</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The operating system to which the software package applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Windows</b>: Windows.</description></item>
        /// <item><description><b>Mac(Apple)</b>: macOS with Apple silicon.</description></item>
        /// <item><description><b>Mac(Intel)</b>: macOS with Intel processors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The software publisher type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local</b>: local upload.</description></item>
        /// <item><description><b>thirdparty</b>: third-party link.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("PublisherType")]
        [Validation(Required=false)]
        public string PublisherType { get; set; }

        /// <summary>
        /// <para>The software ID in the software library. The value can be up to 64 characters in length. You can call <a href="~~ListSoftwarelibSoftware~~">ListSoftwarelibSoftware</a> to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>softwarelib-software-2c51808a3cc8****</para>
        /// </summary>
        [NameInMap("SoftwareId")]
        [Validation(Required=false)]
        public string SoftwareId { get; set; }

        /// <summary>
        /// <para>The software name. The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thunder</para>
        /// </summary>
        [NameInMap("SoftwareName")]
        [Validation(Required=false)]
        public string SoftwareName { get; set; }

        /// <summary>
        /// <para>The file name of the software package. The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestSoftware.exe</para>
        /// </summary>
        [NameInMap("SoftwarePkgName")]
        [Validation(Required=false)]
        public string SoftwarePkgName { get; set; }

        /// <summary>
        /// <para>The size of the software package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SoftwarePkgSize")]
        [Validation(Required=false)]
        public long? SoftwarePkgSize { get; set; }

        /// <summary>
        /// <para>The download URL of the software package. If the publisher type is local, the value is the relative path of the software package in the OSS bucket. If the publisher type is thirdparty, the value is a third-party download URL.</para>
        /// </summary>
        [NameInMap("SoftwareUrl")]
        [Validation(Required=false)]
        public string SoftwareUrl { get; set; }

        /// <summary>
        /// <para>The software version number. The value can be up to 64 characters in length. The combination of operating system and version number must be unique within the same software. If a duplicate exists, a ResourceDuplicated error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("SoftwareVersion")]
        [Validation(Required=false)]
        public string SoftwareVersion { get; set; }

    }

}
