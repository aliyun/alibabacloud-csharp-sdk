// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The extensions that are installed in the specified database.</para>
        /// </summary>
        [NameInMap("InstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribeExtensionsResponseBodyInstalledExtensions> InstalledExtensions { get; set; }
        public class DescribeExtensionsResponseBodyInstalledExtensions : TeaModel {
            /// <summary>
            /// <para>The extension type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>geography_space, self_develop</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The default version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The currently installed version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// <para>The extension name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alton</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The priority of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The extensions on which this extension depends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ganos_networking</para>
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// <para>Specifies whether to restart the application. \<c>true\\</c>: The application is restarted. \<c>false\\</c>: The application is not restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Restart")]
            [Validation(Required=false)]
            public string Restart { get; set; }

        }

        /// <summary>
        /// <para>The overview of the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试建单，请忽略</para>
        /// </summary>
        [NameInMap("Overview")]
        [Validation(Required=false)]
        public string Overview { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>309073D4-9C99-511C-AF84-0C67A6F52E67</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The extensions that are not installed in the specified database.</para>
        /// </summary>
        [NameInMap("UninstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribeExtensionsResponseBodyUninstalledExtensions> UninstalledExtensions { get; set; }
        public class DescribeExtensionsResponseBodyUninstalledExtensions : TeaModel {
            /// <summary>
            /// <para>The extension type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>geography_space, self_develop</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The purpose of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The default version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The currently installed version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// <para>The extension name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alton</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The priority of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The extensions on which this extension depends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ganos_networking</para>
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// <para>Specifies whether to restart the application. \<c>true\\</c>: The application is restarted. \<c>false\\</c>: The application is not restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Restart")]
            [Validation(Required=false)]
            public string Restart { get; set; }

        }

    }

}
