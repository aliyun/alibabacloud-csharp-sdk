// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeExtensionsResponseBody : TeaModel {
        [NameInMap("InstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribeExtensionsResponseBodyInstalledExtensions> InstalledExtensions { get; set; }
        public class DescribeExtensionsResponseBodyInstalledExtensions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>geography_space, self_develop</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alton</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ganos_networking</para>
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Restart")]
            [Validation(Required=false)]
            public string Restart { get; set; }

        }

        [NameInMap("Overview")]
        [Validation(Required=false)]
        public string Overview { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UninstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribeExtensionsResponseBodyUninstalledExtensions> UninstalledExtensions { get; set; }
        public class DescribeExtensionsResponseBodyUninstalledExtensions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>geography_space, self_develop</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.7</para>
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alton</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ganos_networking</para>
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Restart")]
            [Validation(Required=false)]
            public string Restart { get; set; }

        }

    }

}
