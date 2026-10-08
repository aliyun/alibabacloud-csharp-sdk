// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePostgresExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of installed extensions in the specified database.</para>
        /// </summary>
        [NameInMap("InstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribePostgresExtensionsResponseBodyInstalledExtensions> InstalledExtensions { get; set; }
        public class DescribePostgresExtensionsResponseBodyInstalledExtensions : TeaModel {
            /// <summary>
            /// <para>The extension category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>external_access</b>: external access.</description></item>
            /// <item><description><b>index_support</b>: index support.</description></item>
            /// <item><description><b>information_stat</b>: information statistics.</description></item>
            /// <item><description><b>geography_space</b>: geospatial.</description></item>
            /// <item><description><b>vector_engine</b>: vector engine.</description></item>
            /// <item><description><b>timing_engine</b>: time series engine.</description></item>
            /// <item><description><b>data_type</b>: data type.</description></item>
            /// <item><description><b>encrypt_secure</b>: encryption and security.</description></item>
            /// <item><description><b>text_process</b>: text processing.</description></item>
            /// <item><description><b>operation_maintenance</b>: application O&amp;M.</description></item>
            /// <item><description><b>self_develop</b>: self-developed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>information_stat</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The purpose of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostgreSQL load profile repository and report builder</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The default version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.1</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The currently installed version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.1</para>
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// <para>The extension name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg_profile</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user to which the extension belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The extension priority. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: displayed by default.</description></item>
            /// <item><description><b>1</b>: displayed with priority.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The extensions on which this extension depends during installation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{dblink,plpgsql}</para>
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// <remarks>
            /// <para>This parameter is returned only for exclusive extensions (extensions written by the user). Each Alibaba Cloud account can view only its own exclusive extensions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>181578148294****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The overview information about extensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Overview")]
        [Validation(Required=false)]
        public Dictionary<string, object> Overview { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E4448A6-9FE6-4474-A0C1-AA7CFC772CAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of uninstalled extensions in the specified database.</para>
        /// </summary>
        [NameInMap("UninstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribePostgresExtensionsResponseBodyUninstalledExtensions> UninstalledExtensions { get; set; }
        public class DescribePostgresExtensionsResponseBodyUninstalledExtensions : TeaModel {
            /// <summary>
            /// <para>The extension category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>information_stat</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The purpose of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostgreSQL load profile repository and report builder</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The default version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.1</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The currently installed version of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.1</para>
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// <para>The extension name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg_cron</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user to which the extension belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The extension priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The extensions on which this extension depends during installation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{dblink,plpgsql}</para>
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// <remarks>
            /// <para>This parameter is returned only for exclusive extensions (extensions written by the user). Each Alibaba Cloud account can view only its own exclusive extensions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>181578148294****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
