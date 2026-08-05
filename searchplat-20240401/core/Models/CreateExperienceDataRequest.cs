// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateExperienceDataRequest : TeaModel {
        /// <summary>
        /// <para>The data content type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pdf</description></item>
        /// <item><description>text</description></item>
        /// <item><description>html</description></item>
        /// <item><description>doc.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The data size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("dataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>file: file</description></item>
        /// <item><description>url: URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The data content.</para>
        /// <list type="bullet">
        /// <item><description>If dataType is set to file, this field specifies the OSS address of the file.</description></item>
        /// <item><description>If dataType is set to url, this field specifies the HTTP URL of the data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("dataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// <para>The data name. This parameter is required when dataType is set to file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document-analyze</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
