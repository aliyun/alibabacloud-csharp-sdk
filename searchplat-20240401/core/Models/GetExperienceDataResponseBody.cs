// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetExperienceDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5950143C-B8F0-5758-A08A-66F302FD587F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetExperienceDataResponseBodyResult Result { get; set; }
        public class GetExperienceDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The file type.</para>
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1745806839720</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

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
            /// <para>The data type.</para>
            /// <list type="bullet">
            /// <item><description>file</description></item>
            /// <item><description>url.</description></item>
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
            /// <item><description>When dataType is set to file, this field is the OSS address of the file.</description></item>
            /// <item><description>When dataType is set to url, this field is the HTTP URL of the data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx">http://xxx</a></para>
            /// </summary>
            [NameInMap("dataValue")]
            [Validation(Required=false)]
            public string DataValue { get; set; }

            /// <summary>
            /// <para>The data ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1877</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The data name. This parameter is required when dataType is set to file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The service type.</para>
            /// <list type="bullet">
            /// <item><description>document-analyze.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>document-analyze</para>
            /// </summary>
            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729684154</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public long? Updated { get; set; }

        }

    }

}
